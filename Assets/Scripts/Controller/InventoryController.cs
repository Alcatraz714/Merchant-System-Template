using UnityEngine;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour
{
    public InventoryView inventoryView;
    public InventoryModel inventoryModel;

    private void Start()
    {
        inventoryView.OnItemSelected += TrySellItem;
        GameEvents.OnInventoryUpdated += UpdateInventoryUI;
    }

    public bool CanAddToInventory(ItemData item) => inventoryModel.CanAddItem(item, GameManager.Instance.MaxInventoryWeight);

    public void AddToInventory(ItemData item)
    {
        inventoryModel.AddItem(item);
        UpdateInventoryUI();
    }

    public void TrySellItem(ItemData item)
    {
        GameManager.Instance.PlayerCurrency += item.SellingPrice;
        inventoryModel.RemoveItem(item);
        GameEvents.OnItemSold?.Invoke(item);
        UpdateInventoryUI();
    }

    private void UpdateInventoryUI()
    {
        inventoryView.DisplayInventoryItems(inventoryModel.Items);
    }
}
