using UnityEngine;
using TMPro;

public class AlcoholItem : MenuItem
{
    [SerializeField] TextMeshProUGUI _label;
    [SerializeField] TextMeshProUGUI _type;
    [SerializeField] TextMeshProUGUI _volume;
    [SerializeField] TextMeshProUGUI _strength;
    [SerializeField] TextMeshProUGUI _price;

    public void InitializeItem(string label, string type, string volume, string strength, string price)
    {
        SetLabel(label);
        SetType(type);
        SetVolume(volume + "ml");
        SetStrength(strength + "%");
        SetPrice(price + " uah");
    }

    private void SetLabel(string text) => this._label.text = text;
    private void SetType(string text) => this._type.text = text;
    private void SetVolume(string text) => this._volume.text = text;
    private void SetStrength(string text) => this._strength.text = text;
    private void SetPrice(string text) => this._price.text = text;
}
