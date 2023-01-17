using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class MenuEditor : MonoBehaviour
{
    [SerializeField] Transform alcoholItemPrefab;
    [SerializeField] RectTransform contentAclohol;
    [SerializeField] List<AlcoholItemData> alcoholItemsData = new();

    void Start()
    {
        InstantiateAllItems(alcoholItemsData);
    }

    // Удаление всех строк (game objects) и cоздание новых строк из списка моделей
    private void InstantiateAllItems(List<AlcoholItemData> models)
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
    private void InitializeItemView(GameObject instance, AlcoholItemData model)
    {
        instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.label;
        instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.type;
        instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.volume.ToString() + "ml";
        instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.strength.ToString() + "%";
        instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = model.price.ToString() + " uah";
    }

    public void SortByPrice()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.price).ToList();  
        InstantiateAllItems(sortedItems);
    }

    public void SortReversedByPrice()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.price).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortByStrength()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.strength).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortReversedByStrength()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.strength).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortByVolume()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.volume).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortReversedByVolume()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.volume).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortByLabel()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.label).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortReversedByLabel()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.label).ToList();
        InstantiateAllItems(sortedItems);
    }
    public void SortByType()
    {
        var sortedItems = alcoholItemsData.OrderBy(i => i.type).ToList();
        InstantiateAllItems(sortedItems);
    }

    public void SortReversedByType()
    {
        var sortedItems = alcoholItemsData.OrderByDescending(i => i.type).ToList(); ;
        InstantiateAllItems(sortedItems);
    }
}

