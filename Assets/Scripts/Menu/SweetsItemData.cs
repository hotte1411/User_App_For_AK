using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New SweetsItem", menuName = "ScriptableObjects/MenuItems/SweetsItem")]
public class SweetsItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] string _volume;
    [SerializeField] string _price;
    [SerializeField] int _id;

    public string label => this._label;
    public string volume => this._volume;
    public string price => this._price;
    public int id => this._id;
}