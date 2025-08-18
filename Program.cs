// // var pizza = new Pizza();
// // pizza.AddIngredient(new Cheddar());
// // pizza.AddIngredient(new Tomato());
// // pizza.AddIngredient(new Mozarella());
// // System.Console.WriteLine(pizza.Describe());

// // System.Console.WriteLine("Variable of type Cheddar");
// // Ingredient cheddar = new Cheddar();
// // System.Console.WriteLine(cheddar.Name);
// // System.Console.WriteLine("Variable of type Mozerellla");
// // Ingredient mozerella = new Mozarella();
// // System.Console.WriteLine(mozerella.Name);
// // System.Console.WriteLine("Variable of type Tomato");
// // Ingredient tomato = new Tomato();
// // System.Console.WriteLine(tomato.Name);

// // System.Console.WriteLine("Variable of type Ingredient");
// // Ingredient ingredient = new Cheddar();
// // System.Console.WriteLine(ingredient.Name);

// var ingredients = new List<Ingredient>
// {
//   new Cheddar(),
//   new Mozarella(),
//   new Tomato(),
// };

// foreach (var ingredient in ingredients)
// {
//   System.Console.WriteLine($"{ingredient.Name}");
// }

// Console.ReadKey();

// public class Pizza
// {
//   private List<Ingredient> _ingredients = new List<Ingredient>();

//   public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
//   public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
// }

// public class Ingredient
// {
//   public virtual string Name { get; } = "Some ingredient";
//   public int PublicField;
//   public string PublicMethod() => "This method is PUBLIC in the Ingredient class";
//   private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
//   protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";
// }

// public class Cheddar : Ingredient
// {
//   public override string Name => "Cheddar cheese";

//   public void UseMethodsFromBaseClass()
//   {
//     System.Console.WriteLine(PublicMethod());
//     System.Console.WriteLine(ProtectedMethod());
//     // System.Console.WriteLine(PrivateMethod());
//   }
//   public int AgedForMonths { get; }
// }

// public class Tomato : Ingredient
// {
//   public override string Name => "Tomato sauce";
//   public int TomatosIn100Grams { get; }
// }

// public class Mozarella : Ingredient
// {
//   public override string Name => "Mozerella";
//   public bool IsLight { get; }
// }

var numbers = new List<int> { 1, 3, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = true;

NumbersSumCalculator calculator = shallAddPositiveOnly ? new PositiveNumbersCalculator() : new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);
System.Console.WriteLine($"Sum is: {sum}");
Console.ReadKey();

public class NumbersSumCalculator
{
  public virtual int Calculate(List<int> numbers)
  {
    int sum = 0;
    foreach (var number in numbers)
    {
      if (ShallBeAdded(number))
      {
        sum += number;
      }
    }
    return sum;
  }
  protected virtual bool ShallBeAdded(int number) => true;
}

public class PositiveNumbersCalculator : NumbersSumCalculator
{
  protected override bool ShallBeAdded(int number) => number > 0;

  // public int Calculate(List<int> numbers)
  // {
  //   int sum = 0;
  //   foreach (var number in numbers)
  //   {
  //     if (number > 0)
  //     {
  //     sum += number;
  //     }
  //   }
  //   return sum;
  // }
}