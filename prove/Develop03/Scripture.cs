using System;

public class Scripture
{   
    private string _scripture;
    private Reference _reference;
    private string _text;

    public Scripture()
    {
        _reference = new Reference("Matthew", 11, 28, 30);
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        SetScripture(_reference, _text);
    }
    public Scripture(Reference reference)
    {
        _reference = reference;
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        SetScripture(reference, _text);
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        SetScripture(reference, text);
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

}