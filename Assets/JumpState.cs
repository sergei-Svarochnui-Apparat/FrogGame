using DG.Tweening;
using UnityEngine;

public class JumpState : IPlayerState
{
    private MoveCharacter frog;
    private Transform frogTransform;
    private float jumpForce;
    private float gravity;
    private float verticalVelocity;
    private float durationComplete;

    public JumpState(MoveCharacter frog)
    {
        this.frog = frog;
        this.frogTransform = frog.TransFrog;
        this.jumpForce = 12f; // ����� ������� � ���������
        this.gravity = -9.81f;
        this.durationComplete = frog.DurationComplete;
    }

    public void Enter()
    {

        verticalVelocity = jumpForce;

        // �������� ������
        if (Input.GetKey(KeyCode.D))
            frogTransform.GetChild(0).DORotate(new Vector3(0f, 0, -360f), durationComplete, RotateMode.LocalAxisAdd);
        else if (Input.GetKey(KeyCode.A))
            frogTransform.GetChild(0).DORotate(new Vector3(0f, 0, 360f), durationComplete, RotateMode.LocalAxisAdd);
        else if (Input.GetKey(KeyCode.S))
            frogTransform.GetChild(0).DORotate(new Vector3(-360f, 0, 0), durationComplete, RotateMode.LocalAxisAdd);
        else
            frogTransform.GetChild(0).DORotate(new Vector3(360f, 0, 0), durationComplete, RotateMode.LocalAxisAdd);
    }

    public void Update()
    {
        frog.Velocity.y += frog.Gravity * Time.deltaTime;

        // ���� �� ����� - ��������� �������
        if (frog.controller.isGrounded && frog.Velocity.y < 0)
        {
            frog.Velocity.y = -2f; // ��������� ����������� ����
        }

        // ������� ����������
        frog.controller.Move(frog.Velocity * Time.deltaTime);

        // �������� � �������
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 moveDirection = frogTransform.right * moveX - frogTransform.forward * moveZ;

        frog.controller.Move(moveDirection * frog.MoveSpeed * Time.deltaTime);

        // ����������
        verticalVelocity += gravity * Time.deltaTime;
        moveDirection.y = verticalVelocity;
        frog.controller.Move(moveDirection * Time.deltaTime);

        // ������� � Idle ��� �����������
        if (frog.controller.isGrounded && verticalVelocity < 0)
        {
            frog.ChangeState(new IdleState(frog)); 
        }
    }

    public void Exit() { }
}
