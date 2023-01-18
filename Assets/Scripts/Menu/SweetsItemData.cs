using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New SweetsItem", menuName = "ScriptableObjects/MenuItems/SweetsItem")]
public class SweetsItemData : ScriptableObject
{
    [SerializeField] string _label;
    [SerializeField] float _volume;
    [SerializeField] float _price;
    [SerializeField] int _id;

    public string label => this._label;
    public float volume => this._volume;
    public float price => this._price;
    public int id => this._id;
}