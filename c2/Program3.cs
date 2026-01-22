var numbers = new List <int> (5);
var names = new MyList <string> (5);
var beers = new MyList <Beer> (5);


numbers.Add (1);
numbers.Add (2);
numbers.Add (3);
numbers.Add (4);
numbers.Add (5);
numbers.Add (6);

names.Add ("Hola");
names.Add ("Hola1");
names.Add ("Hola2");
names.Add ("Hola3");
names.Add ("Hola4");
names.Add ("Hola5");


beers.Add (new Beer()
{
    Name = "Erdinger",
    Price = 5
});

beers.Add (new Beer()
{
    Name = "Erdinger1",
    Price = 51
});
beers.Add (new Beer()
{
    Name = "Erdinger2",
    Price = 52
});
beers.Add (new Beer()
{
    Name = "Erdinger3",
    Price = 53
});

Console.WriteLine (numbers.GetContent());
Console.WriteLine (names.GetContent());
Console.WriteLine (beers.GetContent());

public class MyList <T>
{
    private List <T> _list;
    private int _limit;

    public MyList (int limit) 
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element){

        if (_list.Count < _limit){
            _list.Add(element);
        }

    }

    public string GetContent()
    {
        string content;
        foreach (var element in _list)
        {
            content += element + ",";
        }
        return content;
    }
}


public class Beer 
{
    public string Name {get; set;}
    public decimal Price {get; set;}

    public override string ToString()
    {
        return Name;
    }

}