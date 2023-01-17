using System;
using UnityEngine;

[Serializable][CreateAssetMenu(fileName = "New AlcoholItem", menuName = "ScriptableObjects/MenuItems")]
public class AlcoholItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] string _type;
    [SerializeField] float _volume;
    [SerializeField] float _strength;
    [SerializeField] float _price;
    [SerializeField] int _id;

    public AlcoholItemData(string label, string type, float volume, float strength, float price)
    {
        _label = label;
        _type = type;
        _volume = volume;
        _strength = strength;
        _price = price;
    }

    public string label => this._label;
    public string type => this._type;
    public float volume => this._volume;
    public float strength => this._strength;
    public float price => this._price;
    public int id => this._id;
}