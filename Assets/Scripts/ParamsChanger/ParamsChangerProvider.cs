using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamsChangerProvider : MonoBehaviour
{
    [SerializeField]
    private ParamsChanger _changer;

    public ParamsChanger GetParamsChanger()
    {
        return _changer;
    }
}
