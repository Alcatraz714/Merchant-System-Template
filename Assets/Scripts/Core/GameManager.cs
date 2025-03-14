using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int PlayerCurrency = 100;
    public float MaxInventoryWeight = 50f;
    public float CurrentWeight = 50f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GameEvents.OnItemBought += UpdateCurrency;
        GameEvents.OnItemSold += UpdateCurrency;
        GameEvents.OnItemBought += UpdateWeight;
        GameEvents.OnItemSold += UpdateWeight;
    }

    private void UpdateCurrency(ItemData item)
    {
        GameEvents.OnCurrencyChanged?.Invoke(PlayerCurrency);
    }

    private void UpdateWeight(ItemData item)
    {
        GameEvents.OnWeightChanged?.Invoke(CurrentWeight);
    }

    private void OnDestroy()
    {
        GameEvents.OnItemBought -= UpdateCurrency;
        GameEvents.OnItemSold -= UpdateCurrency;
        GameEvents.OnItemBought -= UpdateWeight;
        GameEvents.OnItemSold -= UpdateWeight;
    }
}
