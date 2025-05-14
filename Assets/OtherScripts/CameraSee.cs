using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraSee : MonoBehaviour
{
    [SerializeField] private Transform TargetFrog;
    [SerializeField] private Vector3 Offset = new Vector3(0, 2, -5);
    [SerializeField] private float SmoothSpeed = 5f;

    private void LateUpdate()
    {
        if(TargetFrog == null) return;
            Vector3 DesirePosition = TargetFrog.position + Offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position,
            DesirePosition, SmoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
            transform.LookAt(TargetFrog);
        
    }
}
