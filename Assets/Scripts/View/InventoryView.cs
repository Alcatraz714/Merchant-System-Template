using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class InventoryView : MonoBehaviour
{
    public Transform InventoryGrid;
    public GameObject ItemTemplatePrefab;

    public event Action<ItemData> OnItemSelected;

    public void DisplayInventoryItems(List<ItemData> items)
    {
        
        foreach (Transform child in InventoryGrid)
        {
            Destroy(child.gameObject);
        }

        
        foreach (var item in items)
        {
            GameObject newItem = Instantiate(ItemTemplatePrefab, InventoryGrid);
            newItem.GetComponentInChildren<TMP_Text>().text = item.ItemName;
            newItem.GetComponentInChildren<Image>().sprite = item.Icon;

            newItem.GetComponent<Button>().onClick.AddListener(() => OnItemSelected?.Invoke(item));
        }
    }
}
