using TMPro;
using UnityEngine;

public class MyUIcontroller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UITextCoin;
    private MyEvent Event;

    void Start()
    {
        Event = FindFirstObjectByType<MyEvent>();
        Event.OnCoinCollected += UpdateCoinUI;
    }
    private void UpdateCoinUI(int coins)
    {
        UITextCoin.text = $"Coin: {coins}";
    }
    private void OnDestroy()
    {
        Event.OnCoinCollected -= UpdateCoinUI;
    }
}
