using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        SingleTon.Instance.StartGame();
    }
}