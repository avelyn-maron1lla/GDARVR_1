using UnityEngine;

public class GrabFeedback : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 originalPos;

    private void Awake()
    {
        originalScale = transform.localScale;
        originalPos = transform.localPosition;
    }

    public void Grabbed()
    {
        transform.localScale = originalScale * 1.08f;
    }

    public void Released()
    {
        transform.localScale = originalScale;
    }
}