using DG.Tweening;
using NUnit.Framework.Interfaces;
using UnityEngine;

public class IdleState : IPlayerState
{
    private MoveCharacter frog;
    private Transform frogTransform;

    public IdleState(MoveCharacter frog)
    {
        this.frog = frog;
        this.frogTransform = frog.TransFrog;
    }

    public void Enter()
    {
        Debug.Log("Вход в IdleState");
        frogTransform.GetChild(0).DORotate(new Vector3(0f, 90f, 0f), 0.3f).SetEase(Ease.OutQuad);
    }

    public void Update()
    {
        //frog.Velocity.y += frog.Gravity * Time.deltaTime;

        //// Если на земле - фиксируем позицию
        //if (frog.controller.isGrounded && frog.Velocity.y < 0)
        //{
        //    frog.Velocity.y = -2f; // Небольшая прижимающая сила
        //}

        //// Двигаем контроллер
        //frog.controller.Move(frog.Velocity * Time.deltaTime);
        //Debug.Log(frog.controller.isGrounded);
        // Переход в MoveState при нажатии WASD
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)

            //Debug.Log("Idle → Move (WASD нажато)");
            frog.ChangeState(new RunState(frog));
            //Debug.Log("Idle → Move (WASD нажато)");
        
        // Переход в JumpState при нажатии Space
        
        if (Input.GetKeyDown(KeyCode.Space) && frog.controller.isGrounded)

            //Debug.Log("Idle → Jump (Пробел нажат)");
            frog.ChangeState(new JumpState(frog));
            //Debug.Log("Idle → Jump (Пробел нажат)");
        
    }

    public void Exit() { }
}