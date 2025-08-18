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
var taco = new Exercise();
System.Console.WriteLine(taco.GetCountsOfAnimalsLegs());

Console.ReadKey();

public class Exercise {

public List<int> GetCountsOfAnimalsLegs()
{
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };
            
            var result = new List<int>();
            foreach(var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
}
    
public class Animal
{
  public virtual int NumberOfLegs { get; } = 0;
}

public class Lion : Animal
{
  public override int NumberOfLegs { get; } = 4;
}

public class Tiger : Animal
{
  public override int NumberOfLegs { get; } = 4;

}

public class Duck :Animal
{
  public override int NumberOfLegs { get; } = 2;

}

public class Spider : Animal
{
  public override int NumberOfLegs { get; } = 8;
}