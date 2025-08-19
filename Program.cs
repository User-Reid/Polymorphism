Ingredient ingredient = new Cheddar(2, 12);

Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine($"Random ingredient is {randomIngredient}");

System.Console.WriteLine($"is object? {ingredient is object}");
System.Console.WriteLine($"is ingredient? {ingredient is Ingredient}");
System.Console.WriteLine($"is cheddar? {ingredient is Cheddar}");
System.Console.WriteLine($"is mozzarella? {ingredient is Mozarella}");
System.Console.WriteLine($"is tomato sauce? {ingredient is TomatoSauce}");

if (randomIngredient is Cheddar cheddar)
{
  System.Console.WriteLine($"cheddar object: {cheddar}");
}

Console.ReadKey();

Ingredient GenerateRandomIngredient()
{
  var random = new Random();
  var number = random.Next(1, 4);
  if (number == 1) { return new Cheddar(2, 12); }
  if (number == 2) { return new TomatoSauce(1, 3); }
  else return new Mozarella(2, true);
}

public class Pizza
{
  private List<Ingredient> _ingredients = new List<Ingredient>();

  public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
  public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
  public Ingredient(int priceIFExtraTopping)
  {
    System.Console.WriteLine("Constructor from the Ingredient class");
    PriceIFExtraTopping = priceIFExtraTopping;
  }
  public int PriceIFExtraTopping { get; }
  public override string ToString() => Name;

  public virtual string Name { get; } = "Some ingredient";
  public int PublicField;
  public string PublicMethod() => "This method is PUBLIC in the Ingredient class";
  private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
  protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";
}

public class Cheese : Ingredient
{
  public Cheese(int priceIFExtraTopping) : base(priceIFExtraTopping)
  {
    System.Console.WriteLine("This is the Cheese topping");
  }
}

public class Cheddar : Ingredient
{
    public Cheddar(int priceIFExtraTopping, int agedForMonths) : base(priceIFExtraTopping)
  {
    AgedForMonths = agedForMonths;
    System.Console.WriteLine("Constructor from the Cheddar class");
  }
  public override string Name => $"{base.Name}, more specifically, " + $"a Cheddar cheese aged for {AgedForMonths} months.";
  public int AgedForMonths { get; }

  public void UseMethodsFromBaseClass()
  {
    System.Console.WriteLine(PublicMethod());
    System.Console.WriteLine(ProtectedMethod());
    // System.Console.WriteLine(PrivateMethod());
  }
}

public class TomatoSauce : Ingredient
{
  public TomatoSauce(int priceIFExtraTopping, int tomatosIn100Grams) : base(priceIFExtraTopping)
  {
    TomatosIn100Grams = tomatosIn100Grams;
    System.Console.WriteLine("This is the TomatoSauce constructor");
  }
  public override string Name => "Tomato sauce";
  public int TomatosIn100Grams { get; }
}

public class Mozarella : Cheese
{
  public Mozarella(int priceIFExtraTopping, bool isLight) : base(priceIFExtraTopping)
  {
    IsLight = isLight;
    System.Console.WriteLine("This is the Mozerella constructor");
  }
  public override string Name => "Mozerella";
  public bool IsLight { get; }
}
