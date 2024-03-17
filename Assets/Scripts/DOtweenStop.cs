using UnityEngine;
using DG.Tweening;

public class DOtweenStop : MonoBehaviour
{
    private void KillTweening()
    {
        Debug.Log(DOTween.Kill(transform));
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("ArenaCollider"))
            KillTweening();
    }

    private void OnCollisionStay(Collision other) {
        if(other.gameObject.CompareTag("ArenaCollider"))
            KillTweening();
    }
}
