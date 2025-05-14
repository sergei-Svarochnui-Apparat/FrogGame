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
        Debug.Log("Вход в IdleState");
    }

    public void Update()
    {
        frog.Velocity.y += frog.Gravity * Time.deltaTime;

        // Если на земле - фиксируем позицию
        if (frog.controller.isGrounded && frog.Velocity.y < 0)
        {
            frog.Velocity.y = -2f; // Небольшая прижимающая сила
        }

        // Двигаем контроллер
        frog.controller.Move(frog.Velocity * Time.deltaTime);

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 moveDirection = frogTransform.right * moveX - frogTransform.forward * moveZ;

        frog.controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        // Возврат в Idle, если не двигается
        if (moveX == 0 && moveZ == 0)
        {
            frog.ChangeState(new IdleState(frog));
        }


        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space) && frog.controller.isGrounded)
        {
            frog.ChangeState(new JumpState(frog));
        }

    }

    public void Exit() { }
}
