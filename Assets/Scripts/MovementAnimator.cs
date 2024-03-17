using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimator : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;
    private Animator _animator;

    private void Awake() {
        _animator = GetComponent<Animator>();
    }

    private Vector2 GetJoystickChoords()
    {
        return new Vector2(_joystick.Horizontal,_joystick.Vertical);
    }

    private bool IsCharacterMoving()
    {
        Vector2 inputDirection = GetJoystickChoords();
        return inputDirection.magnitude <= 0.5f ? false : true;
    }

    private void SetCharacterBoolInAnimator()
    {
        _animator.SetBool("Walking",IsCharacterMoving());
    }

    private void FixedUpdate() 
    {
        SetCharacterBoolInAnimator();
    }
}
