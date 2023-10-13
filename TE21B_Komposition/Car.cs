
public class Car
{
  public string name;
  public Human driver = new();
  public List<Human> passengers = new();
  public Engine engine = new();
  public Trunk trunk = new();

  public void AddPassenger(Human potentialPassenger)
  {
    if (!potentialPassenger.isCop)
    {
      passengers.Add(potentialPassenger);
    }
  }
}
