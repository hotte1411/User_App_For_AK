using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuEditor : MonoBehaviour
{
    [SerializeField] private Transform itemPrefab;
    [SerializeField] RectTransform contentAclohol;

    private List<Item> items = new();

    private void Start()
    {
        
        items.Add(new Item("Vodka", "vodka", 0.5f, 40, 1000));
        items.Add(new Item("Lager", "beer", 0.5f, 8, 600));
        items.Add(new Item("AppleCidre", "cidre", 0.3f, 3, 1200));

       
        foreach(Transform child in contentAclohol)
        {
           Destroy(child.gameObject);
        }
        
        
        foreach(Item item in items)
        {
            var instance = GameObject.Instantiate(itemPrefab.gameObject, contentAclohol);
            instance.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TMP_Text>().text = item.label;
            instance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = item.type;
            instance.transform.GetChild(2).GetChild(0).gameObject.GetComponent<TMP_Text>().text = item.volume.ToString();
            instance.transform.GetChild(3).GetChild(0).gameObject.GetComponent<TMP_Text>().text = item.strength.ToString();
            instance.transform.GetChild(4).GetChild(0).gameObject.GetComponent<TMP_Text>().text = item.price.ToString();
        }
    }
}
