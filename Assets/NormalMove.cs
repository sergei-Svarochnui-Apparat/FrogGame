using DG.Tweening;
using UnityEngine;

public class NormalMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    private float Gravity = -9.81f;
    [SerializeField] public CharacterController controller;
    private Vector3 Velocity;
    private bool isGround;
    [SerializeField] public Transform TransFrog;
    [SerializeField] private float DurationComplete;
    [SerializeField] private float slideSpeed = 5f;
    [SerializeField] private float slopeForce = 3f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        TransFrog = transform;

        TransFrog.GetChild(0).DOScale(1.13f, 1.5f)
        .SetEase(Ease.OutQuad)
        .SetLoops(-1, LoopType.Yoyo);

    }

    void Update()
    {

        isGround = controller.isGrounded;
        if (isGround)
        {
            TransFrog.GetChild(0).DORotate(new Vector3(0f, 90f, 0f), 0.3f).SetEase(Ease.OutQuad);
        }
        if (isGround && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }
        if (Input.GetKey(KeyCode.Space) && isGround)
        {
            Velocity.y = +12f;
            TransFrog.GetChild(0).DORotate(new Vector3(360f, 0, 0), DurationComplete,
            RotateMode.LocalAxisAdd).SetEase(Ease.OutQuad);
        }
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.D) && isGround)
        {
            Velocity.y = +12f;
            TransFrog.GetChild(0).DORotate(new Vector3(0f, 0, -360f), DurationComplete,
            RotateMode.LocalAxisAdd).SetEase(Ease.OutQuad);
        }
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.A) && isGround)
        {
            Velocity.y = +12f;
            TransFrog.GetChild(0).DORotate(new Vector3(0, 0, 360f), DurationComplete,
            RotateMode.LocalAxisAdd).SetEase(Ease.OutQuad);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space) && isGround)
        {
            Velocity.y = +12f;
            TransFrog.GetChild(0).DORotate(new Vector3(-360f, 0, 0), DurationComplete,
            RotateMode.LocalAxisAdd).SetEase(Ease.OutQuad);
        }
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");
        Vector3 move = transform.right * MoveX - transform.forward * MoveZ;
        controller.Move(move * MoveSpeed * Time.deltaTime);
        Velocity.y += Gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
}
