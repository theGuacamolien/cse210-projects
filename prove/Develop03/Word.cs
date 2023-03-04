using System;


public class WordList
{
    private bool _isHidden;
    private string _text;

    public WordList(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        return _isHidden ? "______" : _text;
    }
}
