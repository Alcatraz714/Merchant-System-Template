using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text CurrencyText;
    public Button GatherResourcesButton;
    public GameObject OverweightPopup;

    private void OnEnable()
    {
        GameEvents.OnCurrencyChanged += UpdateCurrency;
        GameEvents.OnGatheringStateChanged += SetGatheringState;
    }

    private void OnDisable()
    {
        GameEvents.OnCurrencyChanged -= UpdateCurrency;
        GameEvents.OnGatheringStateChanged -= SetGatheringState;
    }

    private void Start()
    {
        UpdateCurrency(GameManager.Instance.PlayerCurrency);
    }

    public void UpdateCurrency(int currency)
    {
        CurrencyText.text = $"Gold: {currency}";
    }

    public void SetGatheringState(bool enabled)
    {
        GatherResourcesButton.interactable = enabled;
        OverweightPopup.SetActive(!enabled);
    }
}
