using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            print("“–»√√≈–");
        }
    }
}
