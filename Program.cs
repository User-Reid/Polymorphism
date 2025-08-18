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
Exercise process = new Exercise();
List<string> wordList = new List<string> {
  "bobcat",
  "wolverine",
  "grizzly"
};
System.Console.WriteLine($"{process.ProcessAll(wordList)}");

Console.ReadKey();

public class Exercise
{
  public List<string> ProcessAll(List<string> words)
  {
    var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

    List<string> result = words;
    foreach (var stringsProcessor in stringsProcessors)
    {
      result = stringsProcessor.Process(result);
    }
    return result;
  }
}

public class StringsProcessor
{
  public virtual List<string> Process(List<string> x)
  {
    return x;
  }
}

public class StringsTrimmingProcessor : StringsProcessor
{
  public override List<string> Process(List<string> words)
  {
    List<string> result = new List<string>();
    foreach (string word in words)
    {
      var half = word.Length / 2;
      result.Add(word.Substring(0, half));
    }
    return result;
  }
}

public class StringsUppercaseProcessor : StringsProcessor
{
  public override List<string> Process(List<string> words)
  {
    List<string> result = new List<string>();
    foreach (string word in words)
    {
      result.Add(word.ToUpper());
    }
    return result;
  }
}