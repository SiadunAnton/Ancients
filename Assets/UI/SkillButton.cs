using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    public void StartCooldownOnButton(int cooldown)
    {
        StartCoroutine(BlockButtonForSeconds(cooldown));
    }

    private IEnumerator BlockButtonForSeconds(int cooldown)
    {
        LockButton();
        for (int i = 0; i < cooldown; i++)
        {
            int currentCooldown = cooldown - i;
            SetTimeValueOnButtonText(currentCooldown);
            yield return new WaitForSeconds(1f);
        }
        UnlockButton();
        ClearButtonText();
    }

    private void LockButton()
    {
        _button.enabled = false;
    }

    private void UnlockButton()
    {
        _button.enabled = true;
    }

    private void SetTimeValueOnButtonText(int time)
    {
        _text.text = time.ToString();
    }

    private void ClearButtonText()
    {
        _text.text = "";
    }
}
