using Unity.VisualScripting.FullSerializer;
using UnityEngine;
public class SwordAttack : IAttack
{
    
    public void Attack(Unit target)
    {
        Debug.Log($"������� ���� ����� �� {target.name}");

        target.health -= 10;
    }
}
