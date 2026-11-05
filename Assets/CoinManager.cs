using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour 
{
    public static CoinManager Instance { get; private set; }
    public int currentGold = 0;
    public TextMeshProUGUI goldUIText;

    private void Awake() 
    {
        if (Instance != null && Instance != this) Destroy(gameObject);
        else Instance = this;
    }

    private void Start() => UpdateGoldUI();

    public void AddGold(int amount) 
    {
        currentGold += amount;
        UpdateGoldUI();
    }

    private void UpdateGoldUI() 
    {
        if (goldUIText != null) goldUIText.text = "Gold: " + currentGold.ToString();
    }
}