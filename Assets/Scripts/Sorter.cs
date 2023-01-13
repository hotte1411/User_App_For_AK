using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorter 
{
    public int SortByPriceFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.price < b.price) return -1;
        else if (a.price > b.price) return 1;
        else return 0;
    }

    public int SortReversedByPriceFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.price < b.price) return 1;
        else if (a.price > b.price) return -1;
        else return 0;
    }

    public int SortByStrengthFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.strength < b.strength) return -1;
        else if (a.strength > b.strength) return 1;
        else return 0;

    }

    public int SortReversedByStrengthFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.strength < b.strength) return 1;
        else if (a.strength > b.strength) return -1;
        else return 0;
    }

    public int SortByVolumeFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.volume < b.volume) return -1;        
        else if (a.volume > b.volume) return 1;
        else return 0;
    }

    public int SortReversedByVolumeFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        if (a.volume < b.volume) return 1;
        else if (a.volume > b.volume) return -1;
        else return 0;
    }

    public int SortByLabelFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        return a.label.CompareTo(b.label);
    }

    public int SortReversedByLabelFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        return b.label.CompareTo(a.label);
    }

    public int SortByTypeFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        return a.type.CompareTo(b.type);
    }

    public int SortReversedByTypeFunc(AlcoholItemModel a, AlcoholItemModel b)
    {
        return b.type.CompareTo(a.type);
    }
}
