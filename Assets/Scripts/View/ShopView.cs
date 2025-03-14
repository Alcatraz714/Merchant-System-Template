using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class ShopView : MonoBehaviour
{
    public Transform ShopGrid; // Assign the ShopPanel in Unity
    public GameObject ItemTemplatePrefab; // Assign the ItemTemplate prefab

    public event Action<ItemData> OnItemSelected;

    public void DisplayShopItems(List<ItemData> items)
    {
        // Clear old items
        foreach (Transform child in ShopGrid)
        {
            Destroy(child.gameObject);
        }

        // Instantiate new items
        foreach (var item in items)
        {
            GameObject newItem = Instantiate(ItemTemplatePrefab, ShopGrid);
            newItem.GetComponentInChildren<TMP_Text>().text = item.ItemName;
            newItem.GetComponentInChildren<Image>().sprite = item.Icon;

            newItem.GetComponent<Button>().onClick.AddListener(() => OnItemSelected?.Invoke(item));
        }
    }
}
