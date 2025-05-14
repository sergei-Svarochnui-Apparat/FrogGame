using UnityEngine;
using DG.Tweening;
public class MoveCharacter : MonoBehaviour
{
    public float Gravity = -9.81f;
    public Vector3 Velocity;

    [SerializeField] public float MoveSpeed = 5f;
    [SerializeField] public float DurationComplete = 0.5f;
    [SerializeField] public Transform TransFrog;
    [HideInInspector] public CharacterController controller;

    private IPlayerState currentState;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        TransFrog = transform;

        TransFrog.GetChild(0).DOScale(1.13f, 1.5f).SetEase(Ease.OutQuad).SetLoops(-1, LoopType.Yoyo);

        ChangeState(new IdleState(this));
    }

    private void Update()
    {
        currentState?.Update();
    }

    public void ChangeState(IPlayerState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }
}