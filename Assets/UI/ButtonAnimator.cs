using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    public void ActivateTrigger(string triggerName)
    {
        try
        {
            _animator.SetTrigger(triggerName);
        }
        catch
        {
            Debug.Log("Unknown trigger.");            
        }
    }
}
