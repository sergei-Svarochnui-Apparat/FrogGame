using UnityEngine;

public class BowAttack : IAttack
{
    public void Attack(Unit target)
    {

        Debug.Log($"�������� �� ���� {target.name}");
        target.health -= 7;
    }
}
