using System;
using UnityEngine;

public class MyEvent : MonoBehaviour
{
    public event Action<int> OnCoinCollected;

    private int QuantCoin = 0;

    private void Start()
    {
        //print(OnCoinCollected);
    }
    public void UpdateCoin()
    {
            QuantCoin++;
            OnCoinCollected?.Invoke(QuantCoin);
    }
}