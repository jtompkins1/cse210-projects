using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Scripture
{   
    private string _scripture;
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private string _randomWord;
    // private string _hiddenWord;
    private string _renderedText;

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
    public void SetScripture(Reference reference, string text)
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
    public void HideWords()
    {
        // put each word from text into a list
        _words = new List<Word>();
        string[] words = _text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

        // select random words
        Random _random = new Random();
        int index = _random.Next(_words.Count);
        _randomWord = _words[index].ToString();
        // replace each letter in the word with _
        Regex.Replace(_randomWord, ".", "_");

    }
    public string GetRenderedText()
    {
        return _renderedText;
    }
    public void SetRenderedText()
    {
        HideWords();
        _renderedText = string.Join(" ", _words);

    }



}