
public class  Reference
{
   private string _book; 
   private int _chapter;
   private int _verse;
   private int _endVerse; 


   public Reference(string  book, int chapter ,int verse,int endVerse )
   {
      book ="John ";
      chapter =3;
      verse = 16;
      endVerse = 17;

     _book = book;
     _chapter = chapter;
     _verse = verse;
     _endVerse = endVerse;
   }

   public Reference (string book, int chapter, int verse ,int startVerse , int endVerse )
   {
       book ="Proverbs ";
       chapter =3;
       verse = 5;
       endVerse = 5;
       startVerse = 6;

       _book = book;
       _chapter = chapter;
       _verse =  verse ;
       _endVerse = endVerse;


   }

   public string GetDisplayText()
   {
    
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}"; 
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
        }
   }
}