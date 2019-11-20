using UnityEngine;
public class PlayerDuckingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.duckingSprite);
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        
    }

    public override void OnUpdate(PlayerController_FSM player)
    {
        if (Input.GetButtonUp("Duck"))
        {
            player.TransitionToState(player._playerIdleState);
        }
    }
}
