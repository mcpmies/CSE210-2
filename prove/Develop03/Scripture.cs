class Scripture
{
    private List<Word> _text = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text.Split(" ").Select(i => new Word(i)).ToList();
    }
    
    public string DisplayScripture()
    {
        return _reference.GetReferenceString() + "\n" + string.Join(' ', _text);
    }

    public void SelectRandomWords()
    {
        
    }

    public void HideRandomWords()
    {
        
    }

    public bool AllHidden()
    {
        return _text.All()
    }
}