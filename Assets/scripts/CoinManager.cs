
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    [Header("UI References")]
    [SerializeField] private TMP_Text coinCounter;
    [SerializeField] private TMP_Text popupText;

    [Header("Popup Settings")]
    [SerializeField] private float popupDuration = 1.5f;

    private int coins = 0;
    private float popupTimer;
    private bool popupActive;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        HidePopup();
        UpdateUI();
    }

    private void Update()
    {
        if (!popupActive)
            return;

        popupTimer -= Time.unscaledDeltaTime;

        if (popupTimer <= 0f)
        {
            popupActive = false;
            HidePopup();

            Debug.Log("POPUP SUCCESSFULLY HIDDEN");
        }
    }

    public void AddCoin(int amount)
    {
        coins += amount;

        UpdateUI();
        ShowPopup(amount);
    }

    private void ShowPopup(int amount)
    {
        if (popupText == null)
        {
            Debug.LogError("Popup Text is missing!");
            return;
        }

        popupText.text = "+" + amount + " Coin!";

        popupText.gameObject.SetActive(true);

        popupTimer = popupDuration;
        popupActive = true;

        Debug.Log("POPUP SHOWN: " + popupText.text);
    }

    private void HidePopup()
    {
        if (popupText != null)
        {
            popupText.gameObject.SetActive(false);
        }
    }

    private void UpdateUI()
    {
        if (coinCounter != null)
        {
            coinCounter.text = "Coins: " + coins;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }
}
