using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ItemData itemData;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (itemData != null)
            TooltipManager.Instance.ShowTooltip(itemData, Input.mousePosition);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.Instance.HideTooltip();
    }
}
