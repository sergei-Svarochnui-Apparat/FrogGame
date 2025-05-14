using UnityEngine;

public class DissapearPl : IPlatformStrategy
{

    private float disappearDelay = 1f;
    private bool isTouched = false;
    private float timer = 0f;

    public void Execute(GameObject obj)
    {
        if (isTouched)
        {
            timer += Time.deltaTime;
            if (timer >= disappearDelay)
                obj.SetActive(false);
        }
    }

    public void OnTouch() 
    {
        isTouched = true;
    }
}
