using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.idleSprite);
        player.head.localPosition = new Vector3(player.head.localPosition.x, .5f, player.head.localPosition.z);
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        
    }

    public override void OnUpdate(PlayerController_FSM player)
    {
        if (Input.GetButton("Jump"))
        {
            player.Rbody.AddForce(Vector3.up * player.jumpForce);
            player.TransitionToState(player._playerJumpState);
        }

        if (Input.GetButtonDown("Duck"))
        {
            player.head.localPosition = new Vector3(player.head.localPosition.x, .8f, player.head.localPosition.z);
            player.TransitionToState(player._playerDuckingState);
        }

        if (Input.GetButtonDown("SwapWeapon"))
        {

        }
    }  
}
