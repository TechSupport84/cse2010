
public class Scripture
{ 
    private  List<Reference> _reference = new List<Reference>();
    private List<Word> _words = new List<Word>(); 

    public Scripture(Reference reference, string text)
    {
          _reference.Add(reference);
          string[] textWords = text.Split(' ');

          foreach (var word in textWords)
           {
            _words.Add(new Word(word));
           }
    }
    public  void HideRandomWords(int numberToHide)
    {
        Random rand   = new Random();
        int count  = 0;
        while (count < numberToHide)
        {
            int index = rand.Next(0, _words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                count ++;
            }

        }

    }
    public  string  GetDisplayText()
    {
         return "";
    }

    public bool IsCompletlyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

