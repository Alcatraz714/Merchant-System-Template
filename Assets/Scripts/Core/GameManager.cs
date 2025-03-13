using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int PlayerCurrency = 100;
    public float MaxInventoryWeight = 50f;

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
    }

    private void UpdateCurrency(ItemData item)
    {
        GameEvents.OnCurrencyChanged?.Invoke(PlayerCurrency);
    }

    private void OnDestroy()
    {
        GameEvents.OnItemBought -= UpdateCurrency;
        GameEvents.OnItemSold -= UpdateCurrency;
    }
}
