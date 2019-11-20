using UnityEngine;
public class PlayerJumpingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.jumpingSprite);
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        player.TransitionToState(player._playerIdleState);
    }

    public override void OnUpdate(PlayerController_FSM player)
    {
        if (Input.GetButtonDown("Duck"))
        {
            player.TransitionToState(new PlayerSpinState());
        }
    }
}
