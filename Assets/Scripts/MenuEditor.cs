using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuEditor : MonoBehaviour
{
    [SerializeField] Transform alcoholItemPrefab;
    [SerializeField] RectTransform contentAclohol;

    [SerializeField] public List<AlcoholItemModel> items = new List<AlcoholItemModel>();

    void Start()
    {
        FillMenuList(items);
        InstantiateAllItems(items);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SortByPrice();
        }
    }

    private void InstantiateAllItems(List<AlcoholItemModel> models)
    {
        foreach (Transform child in contentAclohol)
        {
            Destroy(child.gameObject);
        }

        foreach (var model in models)
        {
            var instance = GameObject.Instantiate(alcoholItemPrefab.gameObject, contentAclohol);
            InitializeItemView(instance, model);
        }
    }

    private void InitializeItemView(GameObject instance, AlcoholItemModel model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.type;
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString();
        instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.strength.ToString();
        instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString();
    }

    private void FillMenuList(List<AlcoholItemModel> items)
    {
        items.Add(new AlcoholItemModel("Vodka", "vodka", 0.5f, 40, 1000));
        items.Add(new AlcoholItemModel("Lager", "beer", 0.5f, 8, 600));
        items.Add(new AlcoholItemModel("AppleCidre", "cidre", 0.3f, 3, 1200));
    }

/*    private void SortByPrice(List<AlcoholItemModel> items)
    {
        items.Sort();
    }*/

    public class AlcoholItemView
    {
        public TextMeshPro label;
        public TextMeshPro type;
        public TextMeshPro volume;
        public TextMeshPro strength;
        public TextMeshPro price;

        public AlcoholItemView(TextMeshPro label, TextMeshPro type, TextMeshPro volume, TextMeshPro strength, TextMeshPro price)
        {
            this.label = label ?? throw new ArgumentNullException(nameof(label));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.volume = volume ?? throw new ArgumentNullException(nameof(volume));
            this.strength = strength ?? throw new ArgumentNullException(nameof(strength));
            this.price = price ?? throw new ArgumentNullException(nameof(price));
        }
    }

    public class AlcoholItemModel
    {
        public string label { get; private set; }
        public string type { get; private set; }
        public float volume { get; private set; }
        public float strength { get; private set; }
        public float price { get; private set; }

        public AlcoholItemModel(string label, string type, float volume, float stregth, float price)
        {
            this.label = label ?? throw new ArgumentNullException(nameof(label));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.volume = volume;
            this.strength = stregth;
            this.price = price;
        }
    }
}
