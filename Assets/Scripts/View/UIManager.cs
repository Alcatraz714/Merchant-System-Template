using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text CurrencyText;
    [SerializeField] private TMP_Text weightText;
    public Button GatherResourcesButton;
    public GameObject OverweightPopup;
    private float maxWeight;

    private void OnEnable()
    {
        GameEvents.OnCurrencyChanged += UpdateCurrency;
        GameEvents.OnWeightChanged += UpdateWeight;
        GameEvents.OnGatheringStateChanged += SetGatheringState;
    }

    private void OnDisable()
    {
        GameEvents.OnCurrencyChanged -= UpdateCurrency;
        GameEvents.OnGatheringStateChanged -= SetGatheringState;
        GameEvents.OnWeightChanged -= UpdateWeight;
    }

    private void Start()
    {
        UpdateCurrency(GameManager.Instance.PlayerCurrency);
    }

    public void UpdateCurrency(int currency)
    {
        CurrencyText.text = $"Gold: {currency}";
    }

    public void UpdateWeight(float weight)
    {
        weightText.text = $"Weight: {weight}";
    }

    public void SetGatheringState(bool enabled)
    {
        GatherResourcesButton.interactable = enabled;
        OverweightPopup.SetActive(!enabled);

        if (!enabled)
        {
            StartCoroutine(HideOverweightPopupAfterDelay());
        }
    }

    private IEnumerator HideOverweightPopupAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        OverweightPopup.SetActive(false);
        GatherResourcesButton.interactable = true;
    }
}
