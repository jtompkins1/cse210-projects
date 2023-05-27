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
        _reference = new Reference("Matthew", 11, 28, 30);
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        SetScripture(_reference, _text);

        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public Scripture(Reference reference)
    {
        _reference = reference;
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        SetScripture(reference, _text);

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
    public void SetScripture(Reference _reference, string text)
    {
        if (_reference.GetStartVerse() == _reference.GetEndVerse())
        {
            _scripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()} {_text}");
        }
        else
        {
            _scripture = ($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()}-{_reference.GetEndVerse()} {_text}");
        }
    }
    public string GetHiddenWord()
    {
        return _hiddenWord;
    }
    public void SetHiddenWord()
    {
        // randomly select 4 words to hide
        // https://softdevpractice.com/blog/enumerable-range-by-example/
        Random _random = new Random();
        // keep track of number of random words chosen each loop
        List<int> selectedWords = new List<int>();

        while (selectedWords.Count < 4)
        // foreach (int i in Enumerable.Range(0,4))
        {
            // select random words

            int index = _random.Next(_words.Count);
            Word _randomWord = _words[index];

            // check if random word is already hidden
            if (_randomWord.GetHiddenStatus() == true && selectedWords.Contains(index))
            {
                // https://www.tutorialspoint.com/csharp/csharp_continue_statement.htm#:~:text=The%20continue%20statement%20in%20C%23,of%20the%20loop%20to%20execute.
                continue;
            }
            else
            {
                selectedWords.Add(index);
                // replace each letter in the word with _
                // https://www.programiz.com/csharp-programming/library/string/replace
                string rw = _randomWord.GetIsHidden();
                _hiddenWord = rw.Replace(rw, new string('_', rw.Length));
                // store hidden status in Word class
                _randomWord.SetIsHidden(_hiddenWord);
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
}