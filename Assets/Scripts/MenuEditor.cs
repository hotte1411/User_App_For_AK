using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class MenuEditor : MonoBehaviour
{
    [SerializeField] AlcoholItem alcoholItemPrefab;
    [SerializeField] RectTransform alcoholContent;
    [SerializeField] List<AlcoholItemData> alcoholItemsData = new();

    private ItemsPool<AlcoholItem> pool;

    void Start()
    {
        pool = new ItemsPool<AlcoholItem>(alcoholItemPrefab, alcoholContent, alcoholItemsData.Count);
        CleanMenu(alcoholContent);
        InitializeAllItems(pool, alcoholItemsData);
    }

    //Заполнение строк game object'а значениями из модели
    private void InitializeAllItems(ItemsPool<AlcoholItem> pool, List<AlcoholItemData> alcoholItemsData) 
    {
        for (int i = 0; i < alcoholItemsData.Count; i++)
        {
            pool.allItems[i].gameObject.SetActive(true);
            InitializeItemView(pool.allItems[i].gameObject, alcoholItemsData[i]);
        }
    }

    private void InitializeItemView(GameObject instance, AlcoholItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.type;
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.strength.ToString() + "%";
        instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
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
        InitializeAllItems(pool, sortedItems);
    }

    public void SortReversedByPrice()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.price).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortByStrength()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.strength).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortReversedByStrength()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.strength).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortByVolume()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.volume).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortReversedByVolume()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.volume).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortByLabel()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.label).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortReversedByLabel()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.label).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortByType()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.type).ToList();
        InitializeAllItems(pool, sortedItems);
    }

    public void SortReversedByType()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.type).ToList(); ;
        InitializeAllItems(pool, sortedItems);
    }
}
