using System.Collections.Generic;
using UnityEngine;
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

        InitializeAlcoholItems(alcoholItemPool, alcoholItemsData);
        InitializeSweetsItems(sweetsItemPool, sweetsItemsData);
        InitializeNoAlcoholItems(noAlcoholItemPool, noAlcoholItemsData);
    }

    private void InitializeAlcoholItems(ItemsPool<AlcoholItem> pool, List<AlcoholItemData> itemsData) 
    {
        for (int i = 0; i < itemsData.Count; i++)
        {
            AlcoholItem instance = pool.allItems[i];
            AlcoholItemData itemData = itemsData[i];

            instance.InitializeItem(itemData.label, itemData.type, itemData.volume, itemData.strength, itemData.price);
            instance.gameObject.SetActive(true);
        }
    }

    private void InitializeSweetsItems(ItemsPool<SweetsItem> pool, List<SweetsItemData> itemsData)
    {
        for (int i = 0; i < itemsData.Count; i++)
        {
            SweetsItem instance = pool.allItems[i];
            SweetsItemData itemData = itemsData[i];

            instance.InitializeItem(itemData.label, itemData.volume, itemData.price);
            instance.gameObject.SetActive(true);
        }
    }

    private void InitializeNoAlcoholItems(ItemsPool<NoAlcoholItem> pool, List<NoAlcoholItemData> itemsData)
    {
        for (int i = 0; i < itemsData.Count; i++)
        {
            NoAlcoholItem instance = pool.allItems[i];
            NoAlcoholItemData itemData = itemsData[i];

            instance.InitializeItem(itemData.label, itemData.volume, itemData.price);
            instance.gameObject.SetActive(true); 
        }
    }

    public void SortByPrice()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.price).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByPrice()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.price).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByStrength()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.strength).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByStrength()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.strength).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByVolume()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.volume).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByVolume()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.volume).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByLabel()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.label).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByLabel()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.label).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortByType()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.type).ToList();
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }

    public void SortReversedByType()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.type).ToList(); ;
        InitializeAlcoholItems(alcoholItemPool, sortedItems);
    }
}