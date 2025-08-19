var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozarella());
System.Console.WriteLine(pizza.ToString());


Console.ReadKey();

public class Pizza
{
  private List<Ingredient> _ingredients = new List<Ingredient>();

  public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
  public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
  public override string ToString() => Name;

  public virtual string Name { get; } = "Some ingredient";
  public int PublicField;
  public string PublicMethod() => "This method is PUBLIC in the Ingredient class";
  private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
  protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";
}

public class Cheese : Ingredient
{

}

public class Cheddar : Cheese
{
  public override string Name => "Cheddar cheese";

  public void UseMethodsFromBaseClass()
  {
    System.Console.WriteLine(PublicMethod());
    System.Console.WriteLine(ProtectedMethod());
    // System.Console.WriteLine(PrivateMethod());
  }
  public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
  public override string Name => "Tomato sauce";
  public int TomatosIn100Grams { get; }
}

public class Mozarella : Cheese
{
  public override string Name => "Mozerella";
  public bool IsLight { get; }
}
