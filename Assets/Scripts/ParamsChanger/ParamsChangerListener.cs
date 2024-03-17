using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamsChangerListener : MonoBehaviour
{
    [SerializeField]
    private Params _params;

    private void OnTriggerEnter(Collider other) 
    {
        if(!other.gameObject.CompareTag("BotWeapon"))
            return;
        var changer = other.gameObject.GetComponent<ParamsChangerProvider>().GetParamsChanger();
        ChangeByParamsChanger(changer);
    }

    public void ChangeByParamsChanger(ParamsChanger changer)
    {
        changer.Change(_params);
    }
}
