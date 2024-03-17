using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActor : MonoBehaviour
{
    [SerializeField]
    private GameObject _element;
    
    public void HideUIElement()
    {
        _element.SetActive(false);
    }

    public void ShowUIElement()
    {
        _element.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
