using DG.Tweening;
using UnityEngine;


public class MyUIAchivements : MonoBehaviour
{
    private MyEvent Event;
    [SerializeField] private CanvasGroup GameObject;

    private void Start()
    {
        Event = FindFirstObjectByType<MyEvent>();
        Event.OnCoinCollected += CheckForAchievement;
    }

    void CheckForAchievement(int coins)
    {
        if (coins >= 10)
        {
            print("Получено достижение скряга");

        }
        if (coins >= 100)
        {

        }
    }
    private void OnDestroy()
    {
        Event.OnCoinCollected -= CheckForAchievement;
    }
}
