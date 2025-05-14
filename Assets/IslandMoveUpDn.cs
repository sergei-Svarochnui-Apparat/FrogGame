using UnityEngine;
using DG.Tweening;

public class IslandMoveUpDn : IStrategyIsland
{
    private Vector3 TargetPosition;
    public IslandMoveUpDn(Vector3 targetPos)
    {
        this.TargetPosition = targetPos;
    }
    public void Confirm(GameObject obj)
    {
        obj.transform.DOMove(TargetPosition, 4f).SetLoops(-1, LoopType.Yoyo);
    }
}
