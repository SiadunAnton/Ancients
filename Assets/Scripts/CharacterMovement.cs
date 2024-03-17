using UnityEngine;
using DG.Tweening;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;
    [SerializeField]
    private float _speed = 1f;
    private bool _blocked = false;

    private void FixedUpdate() 
    {
        if(_blocked)
            return;
        Vector3 movement = new Vector3(-_joystick.Horizontal,0f,-_joystick.Vertical);
        transform.LookAt(transform.position + movement);
        if(movement.magnitude > 0.4f)
            transform.Translate( new Vector3(0f,0f,1f)*_speed*Time.fixedDeltaTime,Space.Self);
    }

    private Vector2 GetJoystickChoords()
    {
        return new Vector2(_joystick.Horizontal,_joystick.Vertical);
    }

    public void BlockMovement()
    {
        _blocked = true;
    }

    public void UnblockMovement()
    {
        _blocked = false;
    }

    public void Roll()
    {
        transform.DOMove(transform.position + transform.forward*5f,0.9f);        
    }
}
