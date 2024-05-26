using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Scripture
{
    private Reference _reference;
    private string _fullScripture;
    private List<Word> _words = new List<Word>(); 

    public Scripture(Reference reference, string text)
    {
        _fullScripture = text;
        _reference = reference;
        string[] textWords = _fullScripture.Split(' ');
        foreach (var word in textWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i=0; i<numberToHide; i++)
        {
            Random randomNum = new Random();
            int index = randomNum.Next(_words.Count);
            while (_words[index].isHidden())
            {
                index = randomNum.Next(_words.Count);
            }
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string currentText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            currentText = currentText + " " + word.GetDisplayText();
        }
        return currentText;
    }
    public bool IsCompletelyHidden()
    {
        bool isEverythingHidden = false;
        foreach (Word wordCheck in _words)
        {
            if (wordCheck.isHidden())
            {
                isEverythingHidden = true;
            }
            else
            {
                isEverythingHidden = false;
                break;
            }
        }
        return isEverythingHidden;
    }
}