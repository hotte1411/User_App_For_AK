public class AlcoholItemModel
{
    public string label { get; private set; }
    public string type { get; private set; }
    public float volume { get; private set; }
    public float strength { get; private set; }
    public float price { get; private set; }

    public AlcoholItemModel(string label, string type, float volume, float stregth, float price)
    {
        this.label = label;
        this.type = type;
        this.volume = volume;
        this.strength = stregth;
        this.price = price;
    }
}