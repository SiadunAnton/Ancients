using System.Collections;
using UnityEngine;

public class VFXSkillModule : SkillModule
{
    [SerializeField]
    private GameObject _effect;
    [SerializeField]
    private Transform _owner;
    [SerializeField]
    private float _delay = 0.6f;
    [SerializeField]
    private Vector3 _relativePosition = new Vector3(0f,1f,0f);

    public override void Activate()
    {
        StartCoroutine(DelayInstantiation());
    }

    IEnumerator DelayInstantiation()
    {
        yield return new WaitForSeconds(_delay);
        Instantiate(_effect, _owner.position + _relativePosition,_owner.transform.rotation);
    }
}
