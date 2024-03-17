using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _slashWeapon;
    [SerializeField]
    private GameObject _stunWeapon;
    
    public void EnableSlashMesh()
    {
        _slashWeapon.SetActive(true);
    }

    public void DisableSlashMesh()
    {
        _slashWeapon.SetActive(false);
    }

    public void EnableStunMesh()
    {
        _stunWeapon.SetActive(true);
    }

    public void DisableStunMesh()
    {
        _stunWeapon.SetActive(false);
    }
}
