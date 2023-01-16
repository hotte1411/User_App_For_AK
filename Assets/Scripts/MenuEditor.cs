using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuEditor : MonoBehaviour
{
    [SerializeField] Transform alcoholItemPrefab;
    [SerializeField] RectTransform contentAclohol;
    [SerializeField] List<AlcoholItemData> alcoholItemsData = new();

    private Sorter sorter = new();

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
        alcoholItemsData.Sort(sorter.SortByPriceFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortReversedByPrice()
    {
        alcoholItemsData.Sort(sorter.SortReversedByPriceFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortByStrength()
    {
        alcoholItemsData.Sort(sorter.SortByStrengthFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortReversedByStrength()
    {
        alcoholItemsData.Sort(sorter.SortReversedByStrengthFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortByVolume()
    {
        alcoholItemsData.Sort(sorter.SortByVolumeFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortReversedByVolume()
    {
        alcoholItemsData.Sort(sorter.SortReversedByVolumeFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortByLabel()
    {
        alcoholItemsData.Sort(sorter.SortByLabelFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortReversedByLabel()
    {
        alcoholItemsData.Sort(sorter.SortReversedByLabelFunc);
        InstantiateAllItems(alcoholItemsData);
    }
    public void SortByType()
    {
        alcoholItemsData.Sort(sorter.SortByTypeFunc);
        InstantiateAllItems(alcoholItemsData);
    }

    public void SortReversedByType()
    {
        alcoholItemsData.Sort(sorter.SortReversedByTypeFunc);
        InstantiateAllItems(alcoholItemsData);
    }
}

