﻿using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class MenuEditor : MonoBehaviour
{
    [SerializeField] AlcoholItem alcoholItemPrefab;
    [SerializeField] RectTransform alcoholContent;
    [SerializeField] List<AlcoholItemData> alcoholItemsData = new();

    [SerializeField] NoAlcoholItem noAlcoholItemPrefab;
    [SerializeField] List<RectTransform> noAlcoholCategories;
    [SerializeField] List<NoAlcoholItemData> noAlcoholItemsData = new();

//    [SerializeField] SweetslItem sweetsItemPrefab;
//    [SerializeField] RectTransform sweetslContent;
//    [SerializeField] List<SweetsItemData> sweetsItemsData = new();

    private ItemsPool<AlcoholItem> alcoholItemPool;
    private ItemsPool<NoAlcoholItem> teaItemPool;
    private ItemsPool<NoAlcoholItem> coffeeItemPool;
//    private ItemsPool<SweetsItem> sweetslItemPool;

    void Start()
    {
        List<NoAlcoholItemData> tea = new();
        List<NoAlcoholItemData> coffee = new();

        foreach(NoAlcoholItemData itemData in noAlcoholItemsData)
        {
            switch (itemData.type)
            {
                case "Чай": 
                    tea.Add(itemData);
                    break;
                case "Кофе":
                    coffee.Add(itemData);
                    break;
                default: break;
            }
        }

        alcoholItemPool = new ItemsPool<AlcoholItem>(alcoholItemPrefab, alcoholContent, alcoholItemsData.Count);
        teaItemPool = new ItemsPool<NoAlcoholItem>(noAlcoholItemPrefab, noAlcoholCategories[0], tea.Count);        
        coffeeItemPool = new ItemsPool<NoAlcoholItem>(noAlcoholItemPrefab, noAlcoholCategories[1], coffee.Count);

        InitializeAllAlcoholItems(alcoholItemPool, alcoholItemsData);
        InitializeAllNoAlcoholItems(teaItemPool, tea);
        InitializeAllNoAlcoholItems(coffeeItemPool, coffee);
    }

    private void InitializeAllAlcoholItems(ItemsPool<AlcoholItem> pool, List<AlcoholItemData> alcoholItemsData) 
    {
        for (int i = 0; i < alcoholItemsData.Count; i++)
        {
            pool.allItems[i].gameObject.SetActive(true);
            InitializeAlcoholItemView(pool.allItems[i].gameObject, alcoholItemsData[i]);
        }
    }

    private void InitializeAllNoAlcoholItems(ItemsPool<NoAlcoholItem> pool, List<NoAlcoholItemData> noAlcoholItemsData)
    {
        for (int i = 0; i < noAlcoholItemsData.Count; i++)
        {
            pool.allItems[i].gameObject.SetActive(true);
            InitializeNoAlcoholItemView(pool.allItems[i].gameObject, noAlcoholItemsData[i]);
        }
    }

    private void InitializeAlcoholItemView(GameObject instance, AlcoholItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.type;
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.strength.ToString() + "%";
        instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
    }

    private void InitializeNoAlcoholItemView(GameObject instance, NoAlcoholItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
    }

    private void CleanMenu(Transform content) 
    { 
        foreach(Transform child in content)
        {
            Destroy(child.gameObject);
        }
    }

    public void SortByPrice()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.price).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByPrice()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.price).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByStrength()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.strength).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByStrength()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.strength).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByVolume()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.volume).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByVolume()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.volume).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByLabel()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.label).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByLabel()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.label).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByType()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.type).ToList();
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByType()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.type).ToList(); ;
        InitializeAllAlcoholItems(alcoholItemPool, sortedItems);
    }
}
