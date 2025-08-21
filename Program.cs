// Ingredient ingredient = new Ingredient();

// Console.ReadKey();

// public class Pizza
// {
//   public Ingredient ingredient;

//   private List<Ingredient> _ingredients = new List<Ingredient>();

//   public void AddIngredient(Ingredient addedIngredient) => _ingredients.Add(addedIngredient);
//   public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
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
//   public override void Prepare() => System.Console.WriteLine("Chop up that tomato young blood");

//   public TomatoSauce(int priceIFExtraTopping, int tomatosIn100Grams) : base(priceIFExtraTopping)
//   {
//     TomatosIn100Grams = tomatosIn100Grams;
//     System.Console.WriteLine("This is the TomatoSauce constructor");
//   }
//   public override string Name => "Tomato sauce";
//   public int TomatosIn100Grams { get; }
// }

// public class Mozarella : Cheese
// {
//   public override void Prepare() => System.Console.WriteLine("Slice thinly and place on top of the pizza");

//   public Mozarella(int priceIFExtraTopping) : base(priceIFExtraTopping)
//   {
//   }
//   public override string Name => "Mozerella";
//   public bool IsLight { get; }
// }

public static class ExerciseShapes
    {
        public static List<double> GetShapesAreas(List<Shape> shapes)
        {
            var result = new List<double>();
            
            foreach(var shape in shapes)
            {
                result.Add(shape.CalculateArea());
            }
            
            return result;
        }
    }

public abstract class Shape
{
  public abstract double CalculateArea();
  
    }
    
    public class Square : Shape
    {
        public double Side { get; }
    
        public Square(double side)
        {
            Side = side;
        }

  public override double CalculateArea() => Side * Side;
    }
    
    
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
    
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        
          public override double CalculateArea() => Width * Height;

    }
    
    public class Circle : Shape
    {
        public double Radius { get; }
    
        public Circle(double radius)
        {
            Radius = radius;
        }

  public override double CalculateArea()
  {
    double squared = Radius * Radius;
    return squared * Math.PI;
          }

    }