using System;
using UnityEngine;

[Serializable][CreateAssetMenu(fileName = "New AlcoholItem", menuName = "ScriptableObjects/MenuItems/AlcoholItem")]
public class AlcoholItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] string _type;
    [SerializeField] string _volume;
    [SerializeField] string _strength;
    [SerializeField] string _price;
    [SerializeField] int _id;

    public string label => this._label;
    public string type => this._type;
    public string volume => this._volume;
    public string strength => this._strength;
    public string price => this._price;
    public int id => this._id;
}