using System;
using TMPro;
using UnityEngine;

public class EventHealth : MonoBehaviour
{
    public event Action<int> OnHealthChanged;
    
    public event Action OnDeath;

    [SerializeField] private int MaxHealth = 100;
    [SerializeField] private int CurrentMaxHealth;
    [SerializeField] private TextMeshProUGUI TxtHealth;

    private void Start()
    {
        CurrentMaxHealth = MaxHealth;
        UpdateUI();
    }

    public void TakeDamage(int damage)
    {
        CurrentMaxHealth -= damage;
        OnHealthChanged?.Invoke(CurrentMaxHealth);
        UpdateUI();
    }
    public void Pickup(int health)
    {
        if (CurrentMaxHealth < 100)
        {
            CurrentMaxHealth += health;

            UpdateUI();
        }
    }
    private void UpdateUI()
    {
        TxtHealth.text = $"Çהמנמגüו: {CurrentMaxHealth}";
    }

    void Die()
    {
        OnDeath?.Invoke();
    }
}
