using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class InventoryView : MonoBehaviour
{
    public Transform InventoryGrid; // Assign the InventoryPanel in Unity
    public GameObject ItemTemplatePrefab; // Assign the ItemTemplate prefab

    public event Action<ItemData> OnItemSelected;

    public void DisplayInventoryItems(List<ItemData> items)
    {
        // Clear old items
        foreach (Transform child in InventoryGrid)
        {
            Destroy(child.gameObject);
        }

        // Instantiate new items
        foreach (var item in items)
        {
            GameObject newItem = Instantiate(ItemTemplatePrefab, InventoryGrid);
            newItem.GetComponentInChildren<TMP_Text>().text = item.ItemName;
            newItem.GetComponentInChildren<Image>().sprite = item.Icon;

            newItem.GetComponent<Button>().onClick.AddListener(() => OnItemSelected?.Invoke(item));
        }
    }
}
