
//====================================================================

public class Tempereture : IComparable
{
    public int _values;

    public Tempereture(int values)
    {
        _values = values;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) 
            return 1;
        var temp = obj as Tempereture;
        if (temp is null)
            throw new ArgumentException("is not a tempreture");
        return this._values.CompareTo(temp._values);
    }
}


