using Unity.VisualScripting.FullSerializer;
using UnityEngine;
public class SwordAttack : IAttack
{
    
    public void Attack(Unit target)
    {
        Debug.Log($"Рубящий удар мечом по {target.name}");

        target.health -= 10;
    }
}
