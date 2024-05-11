using System;

class Word
{
    private string _text;
    private bool _hidden = false;

    //Constructors
    public Word(string wordText)
    {
        _text = wordText;
    }

    //get fuctions
    public string GetStringText()
    {
        return _text;
    }
    public bool GetBoolHidden()
    {
        return _hidden;
    }
    public int GetIntLenght()
    {
        return _text.Count();
    }

    //_hidden set functions
    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
}