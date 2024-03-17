using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private CinemachineImpulseSource _impulseSourse;

    public void Shake()
    {
        Invoke("GenerateImpulse", 0f);
    }
    private void GenerateImpulse()
    {
        _impulseSourse.GenerateImpulse(1f);
    }
}
