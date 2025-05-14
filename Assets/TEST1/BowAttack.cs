using UnityEngine;

public class BowAttack : IAttack
{
    public void Attack(Unit target)
    {

        Debug.Log($"Стрельба из лука {target.name}");
        target.health -= 7;
    }
}
