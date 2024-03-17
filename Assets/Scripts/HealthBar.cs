using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    [SerializeField]
    public int health = 5;
    [SerializeField]
    private List<Image> _healthBarElements;
    [SerializeField]
    private Text _counter;

    public void RefreshInfoAboutHealth(int health)
    {
        this.health = health;
        RefreshBar();
        RefreshCounter();
    }

    private void RefreshBar()
    {
        int length = _healthBarElements.Count;
        for(int i=0; i<length;i++)
        {
            _healthBarElements[i].enabled = i < health;
        }
    }

    private void RefreshCounter()
    {
        _counter.text = health.ToString();
    }
}
