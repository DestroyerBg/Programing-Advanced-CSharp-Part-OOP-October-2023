using _03.ShoppingSpree;

var persons = new List<Person>();
var productPrices = new List<Product>();
try
{
    string[] people = Console.ReadLine()
        .Split(";", StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < people.Length; i++)
    {
        string[] currPerson = people[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
        string name = currPerson[0];
        decimal money = decimal.Parse(currPerson[1]);
        Person person = new Person(name, money);
        persons.Add(person);
    }
    string[] products = Console.ReadLine()
        .Split(";", StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < products.Length; i++)
    {
        string[] currProduct = products[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
        string productName = currProduct[0];
        decimal price = decimal.Parse(currProduct[1]);
        var product = new Product(productName, price);
        productPrices.Add(product);
    }

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
    Environment.Exit(0);
}
string input = string.Empty;
while ((input = Console.ReadLine()) != "END")
{
    string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string personName = data[0];
    string productName = data[1];
    var product = productPrices.FirstOrDefault(p => p.Name == productName);
    var person = persons.FirstOrDefault(p => p.Name == personName);
    if (person is not null && product is not null)
    {
        Console.WriteLine(persons.Find(p => p.Name == personName).BuyProduct(product));
    }
}

foreach (var person in persons)
{
    Console.WriteLine(person.ToString());
}