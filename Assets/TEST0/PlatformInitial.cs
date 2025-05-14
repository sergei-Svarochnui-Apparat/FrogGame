using UnityEngine;

public class PlatformInitial : MonoBehaviour
{
    void Start()
    {
        // ����� ��� ��������� �� ���� (��� �������)
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");

        // �������� ���������:
        platforms[0].GetComponent<ObjectBehaviorController>().SetStrategy(new StayPlatform());
        platforms[1].GetComponent<ObjectBehaviorController>().SetStrategy(new MovePlatform());
        platforms[2].GetComponent<ObjectBehaviorController>().SetStrategy(new DissapearPl());
        
        print("Strategy set " + platforms[2].name);
    }
}

