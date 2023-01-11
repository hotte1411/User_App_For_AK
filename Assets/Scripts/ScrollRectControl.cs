using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollRectControl : MonoBehaviour
{
    private RectTransform rt;
    private List<Transform> items = new List<Transform>();

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            items.Add(child);
        }

        rt = GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0, items.Count * 900);      
    }
}
