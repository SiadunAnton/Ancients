using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTransition : MonoBehaviour
{
    private Animator _animator;

    private void Awake() 
    {
        _animator = GetComponent<Animator>();
    }

    public void Die()
    {
        _animator.SetInteger("DieIndex",Random.Range(0,3));
        _animator.SetTrigger("Die");
    }
}
