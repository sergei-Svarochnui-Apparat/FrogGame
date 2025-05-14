using UnityEngine;

public class Unit : MonoBehaviour
{
    public int health = 30;
    private IAttack attackStr;

    public void SetAttackStrategy(IAttack Strategy)
    {
        attackStr = Strategy;
    }
    
    public void PerformAttack(Unit target)
    {
        if (attackStr != null)
        {
            attackStr.Attack(target);
        }
    }
}
