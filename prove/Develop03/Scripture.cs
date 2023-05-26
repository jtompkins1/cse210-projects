using System;
using System.Collections.Generic;
public class Scripture
{   
    private string _scripture;
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private int _randomWord;
    private Random _random = new Random();

    public Scripture()
    {
        _reference = new Reference("Matthew", 11, 28, 30);
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        SetScripture(_reference, _text);

        _words = new List<Word>();
        string [] words = _text.Split(" ");
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
        string [] words = _text.Split(" ");
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
        string [] words = _text.Split(" ");
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
    // public void HideRandomWords()
    // {
    //     do
    //     {
    //         _randomWord = new Random.Random(_words.Count);
    //     }while (_words[_randomWord].GetIsHidden());
    //     _words[_randomWord].GetIsHidden();
    // }
    public string getHiddenWords()
    {
        string[] _words = _text.Split(' ');
 
        Random random = new Random();
        int index = random.Next(0, _words.Length);
 
        string hiddenWord = _words[index];
        _words.Add(new Word(hiddenWord));
 
        _words[index] = "_____"; // Placeholder for hidden word
 
       return  _text = string.Join(' ', _words);
    }


}