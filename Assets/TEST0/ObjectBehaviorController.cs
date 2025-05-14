using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectBehaviorController : MonoBehaviour
{

    private IPlatformStrategy Strategy;


    public void SetStrategy(IPlatformStrategy newStrategy)
    {
        Strategy = newStrategy;
    }

    private void Update()
    {
        Strategy?.Execute(gameObject);
    }

    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        print("Collision" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player") && Strategy is DissapearPl)
        {
            ((DissapearPl)Strategy).OnTouch();
        }
    }
}