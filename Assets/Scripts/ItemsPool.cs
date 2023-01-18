using System.Collections.Generic;
using UnityEngine;

public class ItemsPool<T> where T : MonoBehaviour
{
    public T prefab;
    public Transform parent;
    public List<T> allItems;

    public ItemsPool(T prefab, Transform container, int count)
    {
        this.prefab = prefab;
        this.parent = container;
        allItems = new List<T>();

        for (int i = 0; i < count; i++)
        {
            var item = GameObject.Instantiate(prefab, parent);
            item.gameObject.SetActive(false);
            allItems.Add(item);
        }
    }



}
