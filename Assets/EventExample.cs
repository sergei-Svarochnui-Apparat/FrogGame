using System;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public event Action OnPlayerDeath;// ��������� ����� 

    private void Start()
    {
        OnPlayerDeath += HandlePlayerDeath;// ������������� �� �������
    }

    void HandlePlayerDeath()
    {
        print("����� ����");
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
