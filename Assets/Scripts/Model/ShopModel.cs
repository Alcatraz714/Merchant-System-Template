using System.Collections.Generic;
using UnityEngine;

public class ShopModel:MonoBehaviour
{
    public List<ItemData> AvailableItems = new List<ItemData>();

    public void LoadShopItems(List<ItemData> items)
    {
        AvailableItems = items;
    }
}
