using System.Collections.Generic;
using UnityEngine;

public class ItemsPool<T> where T : MonoBehaviour
{
    public T prefab { get; }
    public Transform container { get; }
    public List<T> allItems { get; }

    private List<T> _pool;

    public ItemsPool(T prefab, Transform container, int count)
    {
        this.prefab = prefab;
        this.container = container;

        CreatePool(count);
        allItems = this._pool;
    }

    private void CreatePool(int count) 
    {
        this._pool = new List<T>();

        for(int i = 0; i < count; i++)
        {
            CreateObject();
        }
    }

    private T CreateObject(bool isActiveByDefault = false)
    {
        var createdObject = Object.Instantiate(this.prefab, this.container);
        createdObject.gameObject.SetActive(isActiveByDefault);        
        this._pool.Add(createdObject);
        return createdObject;
    }
}
