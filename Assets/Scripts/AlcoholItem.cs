using UnityEngine;
using TMPro;

public class AlcoholItem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _label { get; }
    [SerializeField] TextMeshProUGUI _type;
    [SerializeField] TextMeshProUGUI _volume;
    [SerializeField] TextMeshProUGUI _strength;
    [SerializeField] TextMeshProUGUI _price;
    
    

    public AlcoholItem(string label, string type, string volume, string strength, string price)
    {
        this._label.text = label;
        this._type.text = type;
        this._volume.text = volume;
        this._strength.text = strength;
        this._price.text = price;
    }
}
