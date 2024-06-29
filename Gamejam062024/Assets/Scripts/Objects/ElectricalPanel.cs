using UnityEngine;

public class ElectricalPanel : InteractableObject
{
    protected override void DoOnInteract()
    {
        if (CanInteract) print("interact");
    }
}
