using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderModule : SkillModule
{
    [SerializeField]
    private GameObject _mesh;
    [SerializeField]
    private Transform _owner;
    [SerializeField]
    private float _delay = 0.6f;
    [SerializeField]
    private float _duration = 1f;
    [SerializeField]
    private Vector3 _relativePosition = new Vector3(0f,1f,0f);

    public override void Activate()
    {
        StartCoroutine(DelayMeshInstantiation());
    }

    IEnumerator DelayMeshInstantiation()
    {
        yield return new WaitForSeconds(_delay);
        var mesh = Instantiate(_mesh, _owner.position + _relativePosition,_owner.transform.rotation);
        mesh.transform.Rotate(new Vector3(-90f,0f,0f));
        yield return new WaitForSeconds(_duration);
        GameObject.Destroy(mesh);
    }
}
