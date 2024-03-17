using System.Collections.Generic;
using UnityEngine;

public class StatusPanelUI : MonoBehaviour
{
    private List<StatusUI> _repository = new List<StatusUI>();
    [SerializeField]
    private float width = 120f;

    public void AddAndRefreshPosition(StatusUI status)
    {
        Add(status);
        RefreshPosition();
    }

    private void Add(StatusUI status)
    {
        _repository.Add(status);
    }

    public void RefreshPosition()
    {
        for (int i = 0; i < _repository.Count; i++)
            _repository[i].SetPosition(i * width, 0f);
    }

    public void Remove(StatusUI status)
    {
        _repository.Remove(status);
    }

    public bool IsStatusExistInRepository(StatusUI status)
    {
        return GetStatusById(status.id) != null ? true : false;
    }

    public StatusUI GetStatusById(int id)
    {
        foreach (var statusObject in _repository)
        {
            if (statusObject.id == id)
            {
                return statusObject;
            }
        }
        return null;
    }

}
