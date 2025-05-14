using UnityEngine;

public class MovePlatform : IPlatformStrategy
{
    private float speed = 2f;
    private float distance = 3f;
    private Vector3 startPos;
    private bool isInitialized = false;

    public void Execute(GameObject obj)
    {
        if (!isInitialized)
        {
            startPos = obj.transform.position;
            isInitialized = true;
        }

        float newX = startPos.x + Mathf.Sin(Time.time * speed) * distance;
        obj.transform.position = new Vector3(newX, startPos.y, startPos.z);
    }
}
