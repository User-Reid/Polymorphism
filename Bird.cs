namespace Polymorphism.Flyables
{
  public interface IFlyable
  {
    void Fly();
  }
  public class Bird : IFlyable
  {
    public void Tweet() => System.Console.WriteLine("The bird tweeted");

    public void Fly() => System.Console.WriteLine("Flying using its wings");
  }

  public class Kite : IFlyable
  {
    public void Fly() => System.Console.WriteLine("Flying carried by the wind.");
  }

  public class Plane : IFlyable
  {
    public void Fly()
    {
      System.Console.WriteLine("Flying using jet propulsion.");
    }
  }
}