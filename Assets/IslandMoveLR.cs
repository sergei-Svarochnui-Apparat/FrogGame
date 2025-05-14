using UnityEngine;
using DG.Tweening;

public class IslandMoveLR : IStrategyIsland
{
    private Vector3 TargetPosition;
    public IslandMoveLR(Vector3 TargetPos)
    {
        this.TargetPosition = TargetPos;
    }
    public void Confirm(GameObject obj)
    {
        obj.transform.DOMove(TargetPosition, 2f).SetLoops(-1 , LoopType.Yoyo);
    }
}
