using UnityEngine;

public class RunState : IPlayerState
{
    private MoveCharacter frog;
    private Transform frogTransform;
    private float moveSpeed;

    public RunState(MoveCharacter frog)
    {
        this.frog = frog;
        this.frogTransform = frog.TransFrog;
        this.moveSpeed = frog.MoveSpeed;
    }

    public void Enter() 
    {
        Debug.Log("���� � IdleState");
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

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 moveDirection = frogTransform.right * moveX - frogTransform.forward * moveZ;

        frog.controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        // ������� � Idle, ���� �� ���������
        if (moveX == 0 && moveZ == 0)
        {
            frog.ChangeState(new IdleState(frog));
        }


        // ������
        if (Input.GetKeyDown(KeyCode.Space) && frog.controller.isGrounded)
        {
            frog.ChangeState(new JumpState(frog));
        }

    }

    public void Exit() { }
}
