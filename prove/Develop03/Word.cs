class Word
{
    private string _word;
    private bool _hide;

    public Word(string word)
    {
        _word = word;
        _hide = false;
    }

    public int WordLength()
    {
        int length = _word.Length;
        return length;
    }

    public string GetHiddenDisplay()
    {
        string hiddenDisplay = new string('_', _word.Length);
        return hiddenDisplay;
    }

    public void Hide()
    {
        _hide = true;
    }

    public bool IsHidden()
    {
        return _hide;
    }

}