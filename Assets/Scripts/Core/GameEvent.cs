using System;
using UnityEngine;

public static class GameEvents
{
    public static Action<int> OnCurrencyChanged;
    public static Action<ItemData> OnItemBought;
    public static Action<ItemData> OnItemSold;
    public static Action OnInventoryUpdated;
    public static Action<bool> OnGatheringStateChanged;
}
