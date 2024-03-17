using UnityEngine;
using DG.Tweening;

public class MovementSkillModule : SkillModule
{
    [SerializeField]
    private float _forwardOffset;
    [SerializeField]
    private float _duration;
    [SerializeField]
    private Transform _owner;

    public override void Activate()
    {
        Move();
    }

    public void Move()
    {
        _owner.DOMove(_owner.position + _owner.forward * _forwardOffset,_duration);
    }
}
