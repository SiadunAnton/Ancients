using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBarModule : SkillModule
{
    [SerializeField]
    private StatusBarUI _statusBar;
    [SerializeField]
    private GameObject _statusPrefab;
    [SerializeField]
    private int _statusDuration;

    private void Awake()
    {
        _statusPrefab.GetComponent<StatusUI>().duration = _statusDuration;
    }

    public override void Activate()
    {
        _statusBar.Add(_statusPrefab);
    }
}
