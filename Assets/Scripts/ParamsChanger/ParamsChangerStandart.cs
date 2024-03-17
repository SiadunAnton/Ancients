using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamsChangerStandart : ParamsChanger
{
    [SerializeField]
    private int _value;
    [SerializeField]
    private int _duration;
    [SerializeField]
    private float _gap;
    [SerializeField]
    private ParamsType _type;

    public override void Change(Params inputParams)
    {
        StartCoroutine(ChangeCoroutine(inputParams));
    }

    IEnumerator ChangeCoroutine(Params input)
    {
        yield return new WaitForSeconds(_gap);
        for (int i = 0; i < _duration; i++)
        {
            ChangeParamsByType(input);
            if(_duration == 1)
                yield break;
            yield return new WaitForSeconds(1f);
        }
    }

    private void ChangeParamsByType(Params input)
    {
        switch(_type)
            {
                case ParamsType.health:
                    input.Health += _value;
                    break;
                case ParamsType.armor:
                    input.Armor += _value;
                    break;
                case ParamsType.damage:
                    input.Damage += _value;
                    break;
            }
    }
}
