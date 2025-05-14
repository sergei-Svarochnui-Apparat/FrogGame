using UnityEngine;
using DG.Tweening;

public class ShakeInvisIsland : IStrategyIsland
{
    public void Confirm(GameObject obj)
    {
        obj.transform.DOShakePosition(duration: 0.8f, strength: 0.25f, vibrato: 5).SetLoops(-1, LoopType.Yoyo);
    }
}
