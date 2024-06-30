using System.Collections.Generic;
using UnityEngine;

public class ElectricalPanelHandler : MonoBehaviour
{
    [SerializeField] private List<Element> _elements = new List<Element>();

    public bool ElectricalPanelIsActive { get; private set; }

    private void FixedUpdate()
    {
        ElectricalPanelIsActive = true;

        foreach (Element element in _elements)
        {
            if (!element.ElementIsActive) ElectricalPanelIsActive = false;
        }

        if (ElectricalPanelIsActive) print($"{gameObject.name} is active");
    }
}
