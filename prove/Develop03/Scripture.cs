using System;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _random = new Random();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    //Get functions
    public string GetStringWords()
    {
        string text = $"{_reference.GetStringReference()}:";
        string newWord;
        foreach (Word word in _words)
        {
            if (word.GetBoolHidden()) //show hidden words as ____
            {
                //newWord = "Hidden";
                newWord = new string('_',word.GetIntLenght());
            }
            else
            {
                newWord = word.GetStringText();
            }
            text = $"{text} {newWord}";
        }
        return text;
    }

    //Other functions
    public void HideRandomWord()
    {
        int ranIndex;
        do //Find a random word that is not hidden
        {
            ranIndex = _random.Next(_words.Count());
        }
        while(_words[ranIndex].GetBoolHidden());

        _words[ranIndex].Hide();
    }
    public bool IsFullyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.GetBoolHidden())// if a word is not hidden
            {
                return false;
            }
        }
        return true;
    }
    public void ResetWords()
    {
        foreach(Word word in _words)
        {
            word.Show();
        }
    }
}