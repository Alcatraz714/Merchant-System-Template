using UnityEngine;
using System.Collections.Generic;

public class GatheringManager: MonoBehaviour
{
    private InventoryModel inventoryModel;
    private List<ItemData> allItems;

    public GatheringManager(InventoryModel inventory, List<ItemData> items)
    {
        inventoryModel = inventory;
        allItems = items;
    }

    public void GatherResources()
    {
        /*if (inventoryModel.CurrentWeight >= GameManager.Instance.MaxInventoryWeight)
        {
            GameEvents.OnGatheringStateChanged?.Invoke(false);
            return;
        }*/

        GameEvents.OnGatheringStateChanged?.Invoke(false);

        ItemData randomItem = allItems[Random.Range(0, allItems.Count)];
        inventoryModel.AddItem(randomItem);
        GameEvents.OnGatheringStateChanged?.Invoke(true);
    }
}
