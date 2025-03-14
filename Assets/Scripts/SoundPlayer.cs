using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public static SoundPlayer Instance { get; private set; }

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip buySound;
    [SerializeField] private AudioClip sellSound;
    [SerializeField] private AudioClip gatherSound;
    [SerializeField] private AudioClip errorSound; // For errors like "Not enough gold"

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
    }

    public void PlaySound(SoundType soundType)
    {
        switch (soundType)
        {
            case SoundType.Buy:
                audioSource.PlayOneShot(buySound);
                break;
            case SoundType.Sell:
                audioSource.PlayOneShot(sellSound);
                break;
            case SoundType.Gather:
                audioSource.PlayOneShot(gatherSound);
                break;
            case SoundType.Error:
                audioSource.PlayOneShot(errorSound);
                break;
        }
    }
}

public enum SoundType
{
    Buy,
    Sell,
    Gather,
    Error
}
