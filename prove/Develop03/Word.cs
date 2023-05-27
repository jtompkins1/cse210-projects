using System;
using System.Collections.Generic;
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
    }
    // public bool GetIsHidden()
    // {
    //     return _hidden;
    // }
    public bool IsHidden()
    {
        if (!_text.Contains("_"))
        {
            return false;
        }
        return true;

    }
    // public bool Shown()
    // {
    //     // https://stackoverflow.com/questions/6177352/c-sharp-string-does-not-contain-possible
    //     if(!_text.Contains("_"))
    //     {
    //         _hidden = false;
    //     }
    //     return _hidden;
    // }
    public string GetIsHidden()
    {
        return _text;
    }
    public void SetIsHidden(string text)
    {
        _text = text;
    }



}