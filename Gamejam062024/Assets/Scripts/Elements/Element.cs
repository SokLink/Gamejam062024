using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    [SerializeField] private List<ClemmaData> _clemmsData = new List<ClemmaData>();

    public bool ElementIsActive { get; private set; }

    private void FixedUpdate()
    {
        ElementIsActive = true;

        foreach (ClemmaData clemmaData in _clemmsData)
        {
            if (clemmaData.Connection == null) ElementIsActive = false;
        }
    }
}
