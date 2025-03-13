using UnityEngine;
using System.Collections.Generic;

public class ShopController : MonoBehaviour
{
    public ShopView shopView;
    public ShopModel shopModel;
    public InventoryController inventoryController;

    private void Start()
    {
        shopView.OnItemSelected += TryBuyItem;
        shopView.DisplayShopItems(shopModel.AvailableItems);
    }

    public void TryBuyItem(ItemData item)
    {
        if (GameManager.Instance.PlayerCurrency >= item.BuyingPrice && inventoryController.CanAddToInventory(item))
        {
            GameManager.Instance.PlayerCurrency -= item.BuyingPrice;
            inventoryController.AddToInventory(item);
            GameEvents.OnItemBought?.Invoke(item);
        }
    }
}
