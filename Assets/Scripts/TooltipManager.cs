using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager Instance { get; private set; }

    [SerializeField] private GameObject tooltipPanel;
    [SerializeField] private TMP_Text itemDescriptionText;
    [SerializeField] private TMP_Text itemWeightText;
    [SerializeField] private TMP_Text itemPriceText;
    [SerializeField] private TMP_Text itemRarityText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        tooltipPanel.SetActive(false);
    }

    public void ShowTooltip(ItemData item, Vector2 position)
    {
        tooltipPanel.SetActive(true);
        Vector2 offset = new Vector2(50f, -50f);
        tooltipPanel.transform.position = position + offset;
        //tooltipPanel.transform.position = position; old line for center spawn

        itemDescriptionText.text = item.Description;
        itemWeightText.text = $"Weight: {item.Weight}";
        itemPriceText.text = $"Price: {item.BuyingPrice}";
        
        itemRarityText.text = item.ItemRarity.ToString();
        itemRarityText.color = GetRarityColor(item.ItemRarity);
    }

    public void HideTooltip()
    {
        tooltipPanel.SetActive(false);
    }

    private Color GetRarityColor(Rarity rarity)
    {
        switch (rarity)
        {
            case Rarity.VeryCommon: return Color.gray;
            case Rarity.Common: return Color.white;
            case Rarity.Rare: return Color.blue;
            case Rarity.Epic: return Color.magenta;
            case Rarity.Legendary: return Color.yellow;
            default: return Color.white;
        }
    }
}
