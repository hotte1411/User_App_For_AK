using System;
using UnityEngine;

[Serializable][CreateAssetMenu(fileName = "New NoAlcoholItem", menuName = "ScriptableObjects/MenuItems/NoAlcoholItem")]
public class NoAlcoholItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] string _type;
    [SerializeField] string _volume;
    [SerializeField] string _price;
    [SerializeField] int _id;

    public string label => this._label;
    public string type => this._type;
    public string volume => this._volume;
    public string price => this._price;
    public int id => this._id;
}