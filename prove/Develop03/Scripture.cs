using System;

public class Scripture
{
    private string _scripture;
    private Reference _reference;
    private string _text;
    public Scripture(string text)
    {
        _reference = new Reference("Matthew", 11, 28, 30);
        _text = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
    }
    public Scripture(string text, Reference _reference)
    {
        _reference = new Reference();
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }







}