using System;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public event Action OnPlayerDeath;// обьявляем евент 

    private void Start()
    {
        OnPlayerDeath += HandlePlayerDeath;// подписываемся на событие
    }

    void HandlePlayerDeath()
    {
        print("игрок умер");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //
            OnPlayerDeath?.Invoke();
        }   
    }

   
    private void OnDestroy()
    {
        OnPlayerDeath -= HandlePlayerDeath;
    }
}
