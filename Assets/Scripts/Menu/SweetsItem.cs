using UnityEngine;
using TMPro;

public class SweetsItem : MenuItem
{
    [SerializeField] TextMeshProUGUI _label;
    [SerializeField] TextMeshProUGUI _volume;
    [SerializeField] TextMeshProUGUI _price;

    public void InitializeItem(string label, string volume, string price)
    {
        SetLabel(label);
        SetVolume(volume);
        SetPrice(price);
    }

    private void SetLabel(string text) => this._label.text = text;
    private void SetVolume(string text) => this._volume.text = text;
    private void SetPrice(string text) => this._price.text = text;
}
