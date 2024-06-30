using System.Collections.Generic;
using UnityEngine;

public class Lantern : ActivatedObject
{
    [SerializeField] private GameObject _light;
    [SerializeField] private List<GameObject> _shadows = new List<GameObject>();

    private void FixedUpdate()
    {
        if (IsActive)
        {
            _light.SetActive(true);

            if (_shadows.Count > 0)
            {
                foreach (GameObject shadow in _shadows)
                {
                    shadow.SetActive(false);
                }
            }
        }
    }
}
