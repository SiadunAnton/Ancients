using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skill : MonoBehaviour
{
    [SerializeField]
    private List<SkillModule> _modules = new List<SkillModule>();

    public void Run()
    {
        foreach(var module in _modules)
            module.Activate();
    }
    

    
}
