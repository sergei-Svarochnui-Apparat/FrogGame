using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private MyEvent Event;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Event.UpdateCoin();
            Destroy(gameObject);

        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision != null)
    //    {
    //        Event?.UpdateCoin();
    //        Destroy(gameObject);
    //    }
    //}

}
