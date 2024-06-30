using UnityEngine;

public class Lantern : ActivatedObject
{
    [SerializeField] private GameObject _light;

    private void FixedUpdate()
    {
        if (IsActive) _light.SetActive(true);
        else _light.SetActive(false);
    }
}
