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

        // _words = new List<Word>();
        // string[] words = _text.Split(" ");
        // foreach (string word in words)
        // {
        //     _words.Add(new Word(word));
        // }
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        SetScripture(reference, text);

        // _words = new List<Word>();
        // string[] words = _text.Split(" ");
        // foreach (string word in words)
        // {
        //     _words.Add(new Word(word));
        // }
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
        // _words = new List<Word>();
        // string[] words = _text.Split(" ");
        // foreach (string word in words)
        // {
        //     _words.Add(new Word(word));
        // }
    }
    public string GetHiddenWord()
    {
        return _hiddenWord;
    }
    public void SetHiddenWord()
    {

        // add all words from text to list _words
        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }


        // randomly select 4 words to hide
        // https://softdevpractice.com/blog/enumerable-range-by-example/
        Random _random = new Random();
        foreach (int i in Enumerable.Range(0,4))
        {
            // get index of any word that isn't hidden
            // https://www.interviewbit.com/problems/sets-in-c/#:~:text=A%20set%20is%20a%20collection,%2Fli%3E

            SortedSet<int> shownWordsIndex = new SortedSet<int>();
            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                {
                    shownWordsIndex.Add(j);
                }
                // get words from random index from non hidden words
                int selectedIndex = _random.Next(shownWordsIndex.Count);
                // https://www.tutorialspoint.com/elementat-method-in-chash#:~:text=ElementAt()%20is%20a%20System,element%20at%20a%20particular%20index.
                int selectedWordIndex = shownWordsIndex.ElementAt(selectedIndex);

                Word _randomWord = _words[selectedWordIndex];
                // replace each letter in the word with _
                // https://learn.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-7.0
                _hiddenWord = _randomWord.GetIsHidden().Replace(_randomWord.GetIsHidden(), new string('_', _randomWord.GetIsHidden().Length));
                // _hiddenWord = new string('_', _randomWord.GetIsHidden().Length);
                // store hidden status in Word class
                _randomWord.SetIsHidden(_hiddenWord);
                // remove selected word index from set
                shownWordsIndex.Remove(selectedWordIndex);
            }


        }
    }


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