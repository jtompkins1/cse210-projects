using System;
using System.Collections.Generic;

public class Scripture
{
    private string _scripture;
    private List<Word> _words;
    private string _reference;
    private string _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";

    Reference r1 = new Reference();


    public Scripture()
    {
        _reference = r1.GetReferenceString();
        string[] _words = _text.Split(" ");
    }
    public string GetRenderedText()
    {
        string _text = String.Join(" ", _words);
        return _scripture = ($"{_reference} {_text}");
    }







}