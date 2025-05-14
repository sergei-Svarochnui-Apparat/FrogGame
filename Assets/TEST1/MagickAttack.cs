using UnityEngine;

public class MagickAttack : IAttack
{
    public void Attack(Unit target)
    {
        Debug.Log($"����� {target.name}");
        target.health -= 15;
    }
}
