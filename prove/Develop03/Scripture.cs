using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private string _reference;

    // Constructor to initialize the scripture with reference and text
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Method to display the scripture reference and text
    public void Display()
    {
        Console.Clear(); // Clear the screen before displaying
        Console.WriteLine(_reference); // Display the reference
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText()))); // Display the words
    }

    // Method to randomly hide 'numberToHide' words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var unhiddenWords = _words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < numberToHide; i++)
        {
            if (unhiddenWords.Count == 0) break;
            int index = rand.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
        }
    }

    // Check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
