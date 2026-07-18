// Scripture Memorizer Design - GERARDO GUZMAN - 2026 - CSE210

using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text by spaces and populate the list of Word objects
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-10.0
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Find all indices of words that are NOT hidden yet (Stretch Challenge requirement)

        

        List<int> availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }

        // it help to know  how many words we can actually hide
        int actualToHide = Math.Min(numberToHide, availableIndices.Count);

        // Hide the selected number of words randomly
        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(availableIndices.Count);
            int wordIndexToHide = availableIndices[randomIndex];
            
            _words[wordIndexToHide].Hide();
            availableIndices.RemoveAt(randomIndex); 
            // it help to prevent picking the same word again in this turn
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found at least one(1) word still visible 
            }
        }
        return true;
    }
}