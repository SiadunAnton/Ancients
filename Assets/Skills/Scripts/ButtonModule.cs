using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonModule : SkillModule
{
    [SerializeField]
    private int _cooldown;
    [SerializeField]
    private Button _button;
    private Skill _skill;

    private void Awake()
    {
        _skill = GetComponent<Skill>();
        _button.onClick.AddListener(_skill.Run);    
    }

    public override void Activate()
    {
        _button.GetComponent<SkillButton>().StartCooldownOnButton(_cooldown);
        
    }
}
