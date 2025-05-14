using TMPro;
using UnityEngine;

public class EventUIhealth : MonoBehaviour
{

    [SerializeField] private int damage;
    [SerializeField] private EventHealth UIEventHealth;

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            UIEventHealth.TakeDamage(damage);
        }
    }

}
