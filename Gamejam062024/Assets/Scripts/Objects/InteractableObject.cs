using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
    [SerializeField] private string _playerTag;

    protected bool CanInteract = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _playerTag)
        {
            CanInteract = true;
        }
        else CanInteract = false;
    }

    protected abstract void DoOnInteract();

    private void OnEnable()
    {
        GameInputHandler.OnInteractPressed += DoOnInteract;
    }
    private void OnDisable()
    {
        GameInputHandler.OnInteractPressed -= DoOnInteract;
    }
}
