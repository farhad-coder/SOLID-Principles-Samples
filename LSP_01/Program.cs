/*
CollectionBase array = new Array();
CollectionBase list = new List();

array.Add(2); //Throw Exception
list.Add(3); //Work
*/


//public class CollectionBase
//{
//    public int Count { get; set; }

//    public virtual void Add(object item)
//    {

//    }
//}

//public class Array : CollectionBase
//{
//    public override void Add(object item)
//    {

//    }
//}

//public class List : CollectionBase
//{
//    public override void Add(object item)
//    {

//    }
//}

//********************************************************

CollectionBase array = new Array();
IList list = new List();

//array.Add(2); //Throw Exception
list.Add(3); //Work
public interface IList
{
    void Add(object item);
}

public class CollectionBase
{
    public int Count { get; set; }
}

public class  Array : CollectionBase
{

}

public class List : CollectionBase, IList
{
    public void Add(object item)
    {
        throw new NotImplementedException();
    }
}