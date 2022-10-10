namespace PoC.Models
{
  public class Pokemon
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Seen { get; set; } = false;
    public string Image { get { return $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{ID}.png"; } }
  }
}
