using UnityEngine;
using System.Collections.Generic;

public class GatheringManager : MonoBehaviour
{
    [SerializeField] private InventoryModel inventoryModel;
    [SerializeField] private List<ItemData> allItems;

    public void Initialize(InventoryModel inventory, List<ItemData> items)
    {
        inventoryModel = inventory;
        allItems = items;
    }

    public void GatherResources()
    {
        if (inventoryModel == null)
        {
            Debug.LogError("GatheringManager: inventoryModel is NULL! Did you forget to call Initialize()?");
            return;
        }

        if (allItems == null || allItems.Count == 0)
        {
            Debug.LogError("GatheringManager: allItems is NULL or EMPTY! Assign items in GameManager.");
            return;
        }

        if (inventoryModel.CurrentWeight >= GameManager.Instance.MaxInventoryWeight)
        {
            GameEvents.OnGatheringStateChanged?.Invoke(false);
            SoundPlayer.Instance.PlaySound(SoundType.Error);
            return;
        }

        ItemData randomItem = allItems[Random.Range(0, allItems.Count)];
        inventoryModel.AddItem(randomItem);
        GameEvents.OnGatheringStateChanged?.Invoke(true);
        SoundPlayer.Instance.PlaySound(SoundType.Gather);
    }
}
