using System.Collections.Generic;
using UnityEngine;

public class InventoryModel:MonoBehaviour
{
    public List<ItemData> Items = new List<ItemData>();
    public float CurrentWeight => CalculateWeight();

    public bool CanAddItem(ItemData item, float maxWeight) => (CurrentWeight + item.Weight) <= maxWeight;

    public void AddItem(ItemData item)
    {
        Items.Add(item);
        GameEvents.OnInventoryUpdated?.Invoke();
    }

    public void RemoveItem(ItemData item)
    {
        Items.Remove(item);
        GameEvents.OnInventoryUpdated?.Invoke();
    }

    private float CalculateWeight()
    {
        float totalWeight = 0f;
        foreach (var item in Items) totalWeight += item.Weight;
        return totalWeight;
    }
}
