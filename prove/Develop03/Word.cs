using System;
using System.Collections.Generic;
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;

        // if (_text.Contains ("_"))
        // {
        //     _hidden = true;

        // }else
        // {
        //     _hidden = false;
        // }

    }

    public bool GetHiddenStatus()
    {
        return _hidden;
    }
    public void SetHiddenStatus(string text)
    {
        if (text.Contains("_"))
        {
            _hidden = true;
        }
        else
        {
            _hidden = false;
        }

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