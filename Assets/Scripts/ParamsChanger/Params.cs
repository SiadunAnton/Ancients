using System.Collections;
using UnityEngine;

public class Params : MonoBehaviour
{
    public int Health = 10;
    public int Armor = 3;
    public int Damage = 1;

    [SerializeField]
    private HealthBar _healthBar;

    private void Start()
    {
        if(_healthBar == null)
            return;
        StartCoroutine(UpdateHealthCoroutine());       
    }

    IEnumerator UpdateHealthCoroutine()
    {
        for(;;)
        {
            _healthBar.RefreshInfoAboutHealth(Health);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
