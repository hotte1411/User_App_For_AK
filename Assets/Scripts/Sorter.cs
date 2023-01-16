public class Sorter 
{
    public int SortByPriceFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.price < b.price) return -1;
        else if (a.price > b.price) return 1;
        else return 0;
    }

    public int SortReversedByPriceFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.price < b.price) return 1;
        else if (a.price > b.price) return -1;
        else return 0;
    }

    public int SortByStrengthFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.strength < b.strength) return -1;
        else if (a.strength > b.strength) return 1;
        else return 0;

    }

    public int SortReversedByStrengthFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.strength < b.strength) return 1;
        else if (a.strength > b.strength) return -1;
        else return 0;
    }

    public int SortByVolumeFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.volume < b.volume) return -1;        
        else if (a.volume > b.volume) return 1;
        else return 0;
    }

    public int SortReversedByVolumeFunc(AlcoholItemData a, AlcoholItemData b)
    {
        if (a.volume < b.volume) return 1;
        else if (a.volume > b.volume) return -1;
        else return 0;
    }

    public int SortByLabelFunc(AlcoholItemData a, AlcoholItemData b)
    {
        return a.label.CompareTo(b.label);
    }

    public int SortReversedByLabelFunc(AlcoholItemData a, AlcoholItemData b)
    {
        return b.label.CompareTo(a.label);
    }

    public int SortByTypeFunc(AlcoholItemData a, AlcoholItemData b)
    {
        return a.type.CompareTo(b.type);
    }

    public int SortReversedByTypeFunc(AlcoholItemData a, AlcoholItemData b)
    {
        return b.type.CompareTo(a.type);
    }
}
