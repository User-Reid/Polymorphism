// using Polymorphism.Extensions;

// var cheddar = new Cheddar(2, 12);
// var tomatoSauce = new TomatoSauce(1);
// cheddar.Prepare();
// tomatoSauce.Prepare();

// var multiline = @"I wanna
// dance with
// somebody!";

// System.Console.WriteLine($"The count of lines is {multiline.CountLines()}");


// Console.ReadKey();

// int CountLines(string input) => input.Split('\n').Length;

// public class Pizza
// {
//     public Ingredient ingredient;

//     private List<Ingredient> _ingredients = new List<Ingredient>();

//     public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
//     public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
// }

// public abstract class Ingredient
// {
//   public abstract void Prepare();

//   public Ingredient(int priceIFExtraTopping)
//   {
//     System.Console.WriteLine("Constructor from the Ingredient class");
//     PriceIFExtraTopping = priceIFExtraTopping;
//   }
//   public int PriceIFExtraTopping { get; }
//   public override string ToString() => Name;

//   public virtual string Name { get; } = "Some ingredient";
//   public int PublicField;
//   public string PublicMethod() => "This method is PUBLIC in the Ingredient class";
//   private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
//   protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";
// }

// public abstract class Cheese : Ingredient
// {
//     public Cheese(int priceIFExtraTopping) : base(priceIFExtraTopping)
//   {
//     System.Console.WriteLine("This is the Cheese topping");
//   }
// }

// public class Cheddar : Ingredient
// {
//   public override void Prepare() => System.Console.WriteLine("Buy that shit from the store cuz.");

//     public Cheddar(int priceIFExtraTopping, int agedForMonths) : base(priceIFExtraTopping)
//   {
//     AgedForMonths = agedForMonths;
//     System.Console.WriteLine("Constructor from the Cheddar class");
//   }
//   public override string Name => $"{base.Name}, more specifically, " + $"a Cheddar cheese aged for {AgedForMonths} months.";
//   public int AgedForMonths { get; }

//   public void UseMethodsFromBaseClass()
//   {
//     System.Console.WriteLine(PublicMethod());
//     System.Console.WriteLine(ProtectedMethod());
//     // System.Console.WriteLine(PrivateMethod());
//   }
// }

// public class TomatoSauce : Ingredient
// {
//     public sealed override void Prepare() => System.Console.WriteLine("Chop up that tomato young blood");

//     public TomatoSauce(int priceIFExtraTopping) : base(priceIFExtraTopping)
//     {
//     }
//     public override string Name => "Tomato sauce";
//     public int TomatosIn100Grams { get; }
// }

// // public class PublicMozzarella : Mozarella
// // {

// // }

// public sealed class Mozarella : Cheese
// {
//     public override void Prepare() => System.Console.WriteLine("Slice thinly and place on top of the pizza");

//     public Mozarella(int priceIFExtraTopping) : base(priceIFExtraTopping)
//     {
//     }
//     public override string Name => "Mozerella";
//     public bool IsLight { get; }
// }

var list = new List<int> { 1, 4, 5, 2, 6, 2, 3, 5 };
var result = list.TakeEverySecond();

System.Console.WriteLine(string.Join(", ", result));

Console.ReadKey();

public static class Taco
{
    public static List<int> TakeEverySecond(this List<int> x)
    {
        List<int> onlyOddIndex = new List<int>();
        for (int i = 0; i < x.Count; i++)
        {
            if (i % 2 == 0)
            {
                onlyOddIndex.Add(x[i]);
            }
        }
        return onlyOddIndex;
    }
}