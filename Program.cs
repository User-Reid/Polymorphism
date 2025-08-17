var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Tomato());
pizza.AddIngredient(new Mozarella());
System.Console.WriteLine(pizza.Describe());

Console.ReadKey();

public class Pizza
{
  private List<Ingredient> _ingredients = new List<Ingredient>();

  public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
  public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
  
}

public class Cheddar : Ingredient
{
  public string Name => "Cheddar cheese";
  public int AgedForMonths { get; }
}

public class Tomato : Ingredient
{
  public string Name => "Tomato sauce";
  public int TomatosIn100Grams { get; }
}

public class Mozarella : Ingredient
{
  public string Name => "Mozerella";
  public bool IsLight { get; }
}