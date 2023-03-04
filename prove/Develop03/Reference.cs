using System;

public class Reference
{
    private int _verse;
    private int _endVerse;
    private string _book;
    private int _chapter;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        string[] referenceParts = parts[0].Split(':');
        _book = referenceParts[0];
        _chapter = int.Parse(referenceParts[1]);
        if (referenceParts[2].Contains('-'))
        {
            string[] verseParts = referenceParts[2].Split('-');
            _verse = int.Parse(verseParts[0]);
            _endVerse = int.Parse(verseParts[1]);
        }
        else
        {
            _verse = int.Parse(referenceParts[2]);
            _endVerse = _verse;
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerseNumber(int verse)
    {
        if (verse >= _verse && verse <= _endVerse)
        {
            return (verse - _verse) + 1;
        }
        else
        {
            return -1;
        }
    }

    public string GetRenderedText()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
