
public  abstract class Goal
{
 private string _shortName;
 private string _decription;
 private int _points;

 public Goal(string name , string  description , int   points)
 {
    _shortName = name ;
    _decription = description;
    _points = points;
 }

 public abstract void RecordEvent();
 public abstract bool IsComplete();
 public  abstract string GetDetailsString();
 public abstract  string GetStringRepresentation();


}
