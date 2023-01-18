using System;
using UnityEngine;

[Serializable][CreateAssetMenu(fileName = "New NoAlcoholItem", menuName = "ScriptableObjects/MenuItems/NoAlcoholItem")]
public class NoAlcoholItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] string _type;
    [SerializeField] float _volume;
    [SerializeField] float _price;
    [SerializeField] int _id;

    public NoAlcoholItemData(string label, string type, float volume, float price)
    {
        _label = label;
        _type = type;
        _volume = volume;
        _price = price;
    }

    public string label => this._label;
    public string type => this._type;
    public float volume => this._volume;
    public float price => this._price;
    public int id => this._id;
}