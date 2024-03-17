using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorModule : SkillModule
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private string _trigger;

    public override void Activate()
    {
        _animator.SetTrigger(_trigger);
    }
}
