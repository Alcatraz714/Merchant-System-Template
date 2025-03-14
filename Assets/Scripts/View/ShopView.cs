using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class ShopView : MonoBehaviour
{
    public Transform ShopGrid;
    public GameObject ItemTemplatePrefab;

    public event Action<ItemData> OnItemSelected;

    public void DisplayShopItems(List<ItemData> items)
    {
        foreach (Transform child in ShopGrid)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in items)
        {
            GameObject newItem = Instantiate(ItemTemplatePrefab, ShopGrid);
            TooltipTrigger tooltip = newItem.GetComponent<TooltipTrigger>();
            tooltip.itemData = item;
            newItem.GetComponentInChildren<TMP_Text>().text = item.ItemName;
            newItem.GetComponentInChildren<Image>().sprite = item.Icon;

            newItem.GetComponent<Button>().onClick.AddListener(() => OnItemSelected?.Invoke(item));
        }
    }
}
