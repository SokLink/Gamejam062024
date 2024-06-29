using UnityEngine;

public class WireHead : MonoBehaviour
{
    public Transform WireHeadTransform;
    public CanvasGroup WireHeadCanvasGroup;
    public Transform DefaultParent { get; set; }

    private void OnValidate()
    {
        if (WireHeadTransform == null) WireHeadTransform = transform;
        if (WireHeadCanvasGroup == null && TryGetComponent(out CanvasGroup canvasGroup)) WireHeadCanvasGroup = canvasGroup;
    }
}
