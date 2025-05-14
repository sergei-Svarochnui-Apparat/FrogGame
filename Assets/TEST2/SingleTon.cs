using UnityEngine;

public class SingleTon : MonoBehaviour
{
    //����������� ������ �� ������������ ���������
    public static SingleTon Instance { get; private set;}

    private void Awake()
    {
        // ���� ��������� ��� ���������� � ��� �� ������� ������ � ���������� ���
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else 
        Instance = this;
        DontDestroyOnLoad(gameObject);//������ ������������ ��� �������� ����� �����
    }
    // ������ ������ ���������
    public void StartGame()
    {
        print("Game Started!");
    }
}