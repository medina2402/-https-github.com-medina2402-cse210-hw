using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int number)
    {
        int count = 0;

        while (count < number && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + "\n\n" + text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}