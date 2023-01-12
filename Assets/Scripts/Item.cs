using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string label { get; private set; }
    public string type { get; set; }
    
    public float volume, strength, price;
    private int id, order;

    public Item(string label, string type, float volume, float strength, float price) {
        this.label = label;
        this.type = type;
        this.volume = volume;
        this.strength = strength;
        this.price = price;
    }
}
