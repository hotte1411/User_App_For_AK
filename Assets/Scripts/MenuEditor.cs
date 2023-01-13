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

    [SerializeField] public List<AlcoholItemModel> items = new();

    private Sorter sorter = new();

    void Start()
    {
        FillMenuList(items);
        InstantiateAllItems(items);
    }

    private void Update()
    {

    }

    // Удаление всех строк (game objects) и Создание новых строк из списка моделей
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

    //Заполнение строк game object'а значениями из модели
    private void InitializeItemView(GameObject instance, AlcoholItemModel model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.type;
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.strength.ToString() + "%";
        instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
    }

    //Заполнение списка строками 
    private void FillMenuList(List<AlcoholItemModel> items)
    {
        items.Add(new AlcoholItemModel("Aperol Aperitivo", "liqueur", 150, 16, 110));
        items.Add(new AlcoholItemModel("Ballantine's", "whiskey", 100, 35, 100));
        items.Add(new AlcoholItemModel("Jack Daniel's", "whiskey", 50, 40, 80));
        items.Add(new AlcoholItemModel("Jameson Irish Whiskey", "whiskey", 50, 40, 90));
        items.Add(new AlcoholItemModel("Jägermeister", "liquer", 50, 30, 80));
        items.Add(new AlcoholItemModel("Cubalibra", "coctail", 150, 35, 120));
        items.Add(new AlcoholItemModel("Irish Banana", "coctail", 200, 19, 150));
        items.Add(new AlcoholItemModel("Bacardi Carta Blanca", "rome", 50, 40, 100));
    }

    public void SortByPrice()
    {
        items.Sort(sorter.SortByPriceFunc);
        InstantiateAllItems(items);
    }
    
    public void SortReversedByPrice()
    {
        items.Sort(sorter.SortReversedByPriceFunc);
        InstantiateAllItems(items);
    }

    public void SortByStrength()
    {
        items.Sort(sorter.SortByStrengthFunc);
        InstantiateAllItems(items);
    }

    public void SortReversedByStrength()
    {
        items.Sort(sorter.SortReversedByStrengthFunc);
        InstantiateAllItems(items);
    }

    public void SortByVolume()
    {
        items.Sort(sorter.SortByVolumeFunc);
        InstantiateAllItems(items);
    }

    public void SortReversedByVolume()
    {
        items.Sort(sorter.SortReversedByVolumeFunc);
        InstantiateAllItems(items);
    }

    public void SortByLabel()
    {
        items.Sort(sorter.SortByLabelFunc);
        InstantiateAllItems(items);
    }

    public void SortReversedByLabel()
    {
        items.Sort(sorter.SortReversedByLabelFunc);
        InstantiateAllItems(items);
    }
    public void SortByType()
    {
        items.Sort(sorter.SortByTypeFunc);
        InstantiateAllItems(items);
    }

    public void SortReversedByType()
    {
        items.Sort(sorter.SortReversedByTypeFunc);
        InstantiateAllItems(items);
    }
}
