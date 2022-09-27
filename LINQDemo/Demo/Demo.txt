//Lambda
var lambdaReturn = () => "Hello!";

Console.WriteLine(lambda());

var lambdaDo = () =>
{
    Console.WriteLine("Detta är en lambdafunktion!");
};

lambdaDo();

var printReverse = (string text) =>
{
    var rev = string.Empty;
    for (int i = text.Length -1 ; i >= 0; i--)
    {
        rev += text[i];
    }
    Console.WriteLine(rev);
};

printReverse("hej");

//Select
var itemNames = db.Stock.Select(p => p.Name);
var itemPrices =
    from prod in db.Stock
    select prod.Price;

//Where
var peopleAboveFifty = db.People.Where(p => p.Age > 50);
var peopleUnderFifty =
    from person in db.People
    where person.Age < 50
    select person;


//OrderBy
var sortedByAge = db.People.OrderBy(p => p.Age);
var sortedByPrice =
    from prod in db.Stock
    orderby prod.Price
    select prod;

var sortedByAgeOldestFirst = db.People.OrderByDescending(p => p.Age);
var sortedByPriceExpensiveFirst =
    from prod in db.Stock
    orderby prod.Price descending
    select prod;

//First
var niklas = db.People.FirstOrDefault(p => p.Name.ToLower().Equals("niklas"));
var kalle =
    (from person in db.People
     where person.Name.ToLower() == "Kalle"
     select person).FirstOrDefault();

// MaxBy
var oldest = db.People.MaxBy(p => p.Age);

// MinBy
var youngest = db.People.MinBy(p => p.Age);