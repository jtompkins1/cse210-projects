using System;
using System.Collections.Generic;
public class Scripture
{   
    private string _scripture;
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private string _hiddenWord;
    private string _renderedText;
    private string _hiddenScripture;
    public Scripture()
    {
        _reference = new Reference("Jacob", 6, 12);
        _text = "O be wise; what can I say more?";
        SetScripture(_reference, _text);

        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        SetScripture(reference, text);

        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public string GetScripture()
    {
        return _scripture;
    }
    //set initial scripture prior to hiding words
    private void SetScripture(Reference _reference, string text)
    {
        if (_reference.GetStartVerse() == _reference.GetEndVerse())
        {
            _scripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()} {_text}");
        }
        else
        {
            _scripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()}-{_reference.GetEndVerse()} {_text}");
        }
        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public string GetHiddenWord()
    {
        return _hiddenWord;
    }
    public void SetHiddenWord()
    {
        Random _random = new Random();
        // randomly select 3 words to hide
        // https://softdevpractice.com/blog/enumerable-range-by-example/
        foreach (int i in Enumerable.Range(0,3))
        {
            // Random _random = new Random();
            // select random words
            int index = _random.Next(_words.Count);
            Word _randomWord = _words[index];
            // replace each letter in the word with _
            // https://learn.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-7.0
            _hiddenWord = _randomWord.GetIsHidden().Replace(_randomWord.GetIsHidden(), new string('_', _randomWord.GetIsHidden().Length));
            // store hidden status in Word class
            _randomWord.SetIsHidden(_hiddenWord);
        }
    }


    // UNSUCCESSFULL ATTEMPT AT SELECTING ONLY FROM SHOWN WORDS
    // public void SetHiddenWord() 
    // {
    //     // randomly select 4 words to hide
    //     // https://softdevpractice.com/blog/enumerable-range-by-example/
    //     Random _random = new Random();
    //     List<Word> _remainingWords = _words.Where(word => !word.GetHiddenStatus()).ToList();
    //     List<Word> _selectedWords = new List<Word>();
    //     // // keep track of number of random words chosen each loop

    //     // while (_selectedWords.Count < 4 && _remainingWords.Count > 0)
    //     foreach (int i in Enumerable.Range(0,4))
    //     {
    //         // select random words
    //         int index = _random.Next(_remainingWords.Count);
    //         Word _randomWord = _remainingWords[index];
    //         _selectedWords.Add(_randomWord);
    //         _remainingWords.RemoveAt(index);


    //         // check if random word is already hidden
    //         if (_randomWord.GetHiddenStatus() == false && !_selectedWords.Contains(_randomWord))
    //         {
    //             // _selectedWords.Add(index);
    //             // replace each letter in the word with _
    //             // https://www.programiz.com/csharp-programming/library/string/replace
    //             // https://learn.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-7.0
    //             _hiddenWord = _randomWord.GetIsHidden().Replace(_randomWord.GetIsHidden(), new string('_', _randomWord.GetIsHidden().Length));
    //             // store hidden status in Word class
    //             _randomWord.SetIsHidden(_hiddenWord);
    //         }
    //         if (_selectedWords.Count >= _words.Count)
    //         {
    //             // https://www.tutorialspoint.com/csharp/csharp_continue_statementhtm#:~:text=The%20continue%20statement%20in%20C%23,of%20the%20loop%20to%20execute.
    //             // continue;
    //             // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements
    //             break;
    //         }
    //     }
    // }

    public string GetRenderedText()
    {
        return _renderedText;
    }
    // set text of scripture verses with hidden words
    public void SetRenderedText()
    {
        SetHiddenWord();

        List<string> withHiddenWords = new List<string>();
        foreach (Word word in _words)
        {
            withHiddenWords.Add(word.GetIsHidden());
        }
        // join words to string
        _renderedText = string.Join(" ", withHiddenWords);
    }
    public string GetHiddenScripture()
    {
        return _hiddenScripture;
    }
    //set scripture including hidden words
    public void SetHiddenScripture()
    {
        // SetHiddenWord();
        SetRenderedText();
        if (_reference.GetStartVerse() == _reference.GetEndVerse())
        {
            _hiddenScripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()} {_renderedText}");
        }
        else
        {
            _hiddenScripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()}-{_reference.GetEndVerse()} {_renderedText}");
        }
    }
    public bool IsCompletelyHidden()
    {
        SetRenderedText();
        foreach (string word in _renderedText.Split(" "))
        {
            foreach (char letter in word)
            {
            if (letter.ToString() != "_")
            {
                return false;
            }
            }

        }
        return true;
    }
}