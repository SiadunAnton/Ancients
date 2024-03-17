using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    public float duration;
    public int id = 0;

    private RectTransform _transform;

    private void Awake()
    {
        _transform = GetComponent<RectTransform>();
    }

    public void SetPosition(float x, float y)
    {
        _transform.localPosition = new Vector3(x, y, 0f);
    }

}
