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

    [SerializeField] SweetsItem sweetsItemPrefab;
    [SerializeField] RectTransform sweetslContent;
    [SerializeField] List<SweetsItemData> sweetsItemsData = new();

    private ItemsPool<AlcoholItem> alcoholItemPool;
    private ItemsPool<NoAlcoholItem> noAlcoholItemPool;
    private ItemsPool<SweetsItem> sweetsItemPool;

    void Start()
    {
        alcoholItemPool = new ItemsPool<AlcoholItem>(alcoholItemPrefab, alcoholContent, alcoholItemsData.Count);
        sweetsItemPool = new ItemsPool<SweetsItem>(sweetsItemPrefab, sweetslContent, sweetsItemsData.Count);
        noAlcoholItemPool = new ItemsPool<NoAlcoholItem>(noAlcoholItemPrefab);
        foreach(NoAlcoholItemData itemData in noAlcoholItemsData)
        {
            switch (itemData.type)
            {
                case "Чай":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[0]);
                    break;
                case "Кофе":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[1]);
                    break;
                case "Газировка":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[2]);
                    break;
                case "Вода":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[3]);
                    break;
                case "Сок":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[4]);
                    break;
                case "Другое":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[5]);
                    break;
                case "Молоко":
                    noAlcoholItemPool.AddToPool(noAlcoholCategories[6]);
                    break;
                default: break;
            }
        }

        InitializeAllAlcoholItems(alcoholItemPool, alcoholItemsData);
        InitializeAllSweetsItems(sweetsItemPool, sweetsItemsData);
        InitializeAllNoAlcoholItems(noAlcoholItemPool, noAlcoholItemsData);
    }

    private void InitializeAllAlcoholItems(ItemsPool<AlcoholItem> pool, List<AlcoholItemData> itemData) 
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InitializeAlcoholItemView(pool.allItems[i].gameObject, itemData[i]);
            pool.allItems[i].gameObject.SetActive(true);
        }
    }

    private void InitializeAllSweetsItems(ItemsPool<SweetsItem> pool, List<SweetsItemData> itemData)
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InitializeSweetsItemView(pool.allItems[i].gameObject, itemData[i]);
            pool.allItems[i].gameObject.SetActive(true);
        }
    }

    private void InitializeAllNoAlcoholItems(ItemsPool<NoAlcoholItem> pool, List<NoAlcoholItemData> itemData)
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InitializeNoAlcoholItemView(pool.allItems[i].gameObject, itemData[i]);
            pool.allItems[i].gameObject.SetActive(true); 
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

    private void InitializeSweetsItemView(GameObject instance, SweetsItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "g";
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
    }

    private void InitializeNoAlcoholItemView(GameObject instance, NoAlcoholItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
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
