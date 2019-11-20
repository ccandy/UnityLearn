using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_FSM : MonoBehaviour
{
    #region Player Variables

    public float jumpForce;
    public Transform head;
    public Transform weapon01;
    public Transform weapon02;

    public Sprite idleSprite;
    public Sprite duckingSprite;
    public Sprite jumpingSprite;
    public Sprite spinningSprite;

    private SpriteRenderer face;
    private Rigidbody rbody;
    public Rigidbody Rbody
    {
        set
        {
            rbody = value;
        }

        get
        {
            return rbody;
        }
    }

    #endregion


    #region State
    private PlayerBaseState _currentState;
    public PlayerBaseState CurrentState
    {
        set
        {
            _currentState = value;
        }
        get
        {
            return _currentState;
        }
    }

    public readonly PlayerIdleState _playerIdleState = new PlayerIdleState();
    public readonly PlayerJumpingState _playerJumpState = new PlayerJumpingState();
    public readonly PlayerDuckingState _playerDuckingState = new PlayerDuckingState();
    public readonly PlayerSpinState _playerSpinState = new PlayerSpinState();

    #endregion



    private void Awake()
    {
        face = GetComponentInChildren<SpriteRenderer>();
        rbody = GetComponent<Rigidbody>();
        SetExpression(idleSprite);
    }

    private void Start()
    {
        TransitionToState(_playerIdleState);
    }

    // Update is called once per frame
    void Update()
    {
        _currentState.OnUpdate(this);
    }

    public void SetExpression(Sprite newExpression)
    {
        face.sprite = newExpression;
    }

    public void TransitionToState(PlayerBaseState state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _currentState.OnCollisionEnter(this);
    }

    

}
