using System;
using System.Linq;

public class Scripture
{
    private string _scriptureText;
    private string _reference;
    private WordList[] _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _scriptureText = text;
        string[] words = text.Split(' ');
        _words = new WordList[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            _words[i] = new WordList(words[i]);
        }
    }

    public void HideWords(int count)
    {
        Random rnd = new Random();
        int[] indexes = Enumerable.Range(0, _words.Length).OrderBy(x => rnd.Next()).Take(count).ToArray();
        foreach (int index in indexes)
        {
            _words[index].Hide();
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetRenderedText()
    {
        string renderedText = "";
        foreach (WordList word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return $"{_reference}\n\n{renderedText}";
    }
}
