using System.Collections;

public class FiveIntegers : IEnumerable
{
    public int[] _values;
    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 };
    }
    public IEnumerator GetEnumerator()
    {
        // we reblace enumerators functions to yield "yield is keyword made by microsoft have enumerators method in-it without using enomerators manual"
        foreach(var item in _values)
        {
            yield return item;
        }
    }

    //class Enumerator : IEnumerator
    //{



    //    int currentinddex = -1;
    //    FiveIntegers _integers;


    //    public Enumerator(FiveIntegers integers)
    //    {
    //        _integers = integers;

    //    }

    //    public object Current
    //    {
    //        get
    //        {
    //            if(currentinddex == -1)
    //                throw new NotImplementedException("enumeration not started");
    //            if (currentinddex == _integers._values.Length) 
    //                throw new NotImplementedException("enumeration has ended");
    //            return _integers._values[currentinddex];
    //        }

    //    }
    //    public bool MoveNext()
    //    {
    //        if (currentinddex >= _integers._values.Length - 1)
    //            return false;
    //        return ++currentinddex < _integers._values.Length;
    //    }

    //    public void Reset() => currentinddex = -1;

    //}



}