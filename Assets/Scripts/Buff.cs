using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParamsChanger))]
public class Buff : SkillModule
{
    [SerializeField]
    private ParamsChanger _changer;
    [SerializeField]
    private Params _onwerParams;

    public override void Activate()
    {
        _changer.Change(_onwerParams);
    }
}
