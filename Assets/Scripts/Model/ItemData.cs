using UnityEngine;

public enum ItemType { Materials, Weapons, Consumables, Treasure }
public enum Rarity { VeryCommon, Common, Rare, Epic, Legendary }

[CreateAssetMenu(fileName = "NewItem", menuName = "Shop/Item")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public ItemType Type;
    public Sprite Icon;
    public string Description;
    public int BuyingPrice;
    public int SellingPrice;
    public float Weight;
    public Rarity ItemRarity;
}
