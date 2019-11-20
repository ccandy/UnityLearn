using UnityEngine;
public class PlayerSpinState : PlayerBaseState
{
    private float rotation = 0;
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.spinningSprite);
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        player.transform.rotation = Quaternion.identity;
        player.TransitionToState(player._playerIdleState);
    }

    public override void OnUpdate(PlayerController_FSM player)
    {
        float amountToRotate = 900 * Time.deltaTime;
        rotation += amountToRotate;
        if(rotation < 360)
        {
            player.transform.Rotate(Vector3.up, amountToRotate);
        }
        else
        {
            player.transform.rotation = Quaternion.identity;
            player.TransitionToState(player._playerJumpState);
        }

    }
}
