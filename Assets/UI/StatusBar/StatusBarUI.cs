using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(StatusPanelUI))]
public class StatusBarUI : MonoBehaviour
{
    private StatusPanelUI _statusPanel;
    private StatusCoroutineDictionaryUI _coroutineDictionary = new StatusCoroutineDictionaryUI();
    [SerializeField]
    private bool _renewal = false;

    private void Awake()
    {
        _statusPanel = GetComponent<StatusPanelUI>();
    }

    public bool IsStatusActive(StatusUI status)
    {
        return _statusPanel.IsStatusExistInRepository(status);
    }

    public void Add(GameObject statusPrefab)
    {
        var status = statusPrefab.GetComponent<StatusUI>();
        if (IsStatusActive(status))
        {
            if (_renewal)
            {
                StopLinkedToStatusCoroutine(status);
                CreateStatusAndStartCoroutine(statusPrefab);
            }
            else
            {
                return;
            }
        }
        else
        { 
            CreateStatusAndStartCoroutine(statusPrefab);
        }
    }

    private void CreateStatusAndStartCoroutine(GameObject statusPrefab)
    {
        var instantiatedStatus = Instantiate(statusPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity, transform);
        var status = instantiatedStatus.GetComponent<StatusUI>();
        _statusPanel.AddAndRefreshPosition(status);
        Coroutine coroutine = StartCoroutine(RunCoroutine(status));
        _coroutineDictionary.Add(status, coroutine);
    }

    IEnumerator RunCoroutine(StatusUI status)
    {
        yield return new WaitForSeconds(status.duration);
        Remove(status); 
    }

    private void Remove(StatusUI status)
    {
        _coroutineDictionary.Remove(status);
        _statusPanel.Remove(status);
        Destroy(status.gameObject);
        _statusPanel.RefreshPosition();
    }

    private void StopLinkedToStatusCoroutine(StatusUI status)
    {
        var existedStatus = _statusPanel.GetStatusById(status.id);
        StopCoroutine(_coroutineDictionary.Remove(existedStatus));
        Remove(existedStatus);
    }
}
