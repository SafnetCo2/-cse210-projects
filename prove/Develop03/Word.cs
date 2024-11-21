public class Word
{
    public string Reference{ get; }
    public string IsText{get;}
    public bool IsHidden{ get; private set; }
    public Word(string reference,string text)
    {
        Reference = reference;
        IsText = text;
        IsHidden = false;
        
    }
    public void Hide()
    {
        IsHidden = true;
    }
    public string GetDisplayText()
    {
        return  IsHidden ? new string('_', IsText.Length) : IsText;
    }
}
    
