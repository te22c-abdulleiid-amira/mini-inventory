public class Character
{
  public int Hp;
  public string Name;
  public Inventory Backpack;

  public Character()
  {
    Backpack = new();
  }
}