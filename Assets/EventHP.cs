using UnityEngine;

public class EventHP : MonoBehaviour
{
    [SerializeField] private int HealthPickup = 25;
    [SerializeField] EventHealth Event;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Event !=null)
        {
            Event.Pickup(HealthPickup);

            Destroy(gameObject);
        }
    }
}
