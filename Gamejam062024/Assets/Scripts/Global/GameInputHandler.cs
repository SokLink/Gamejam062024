using System;
using UnityEngine;

public class GameInputHandler : MonoBehaviour
{
    public static event Action OnJumpPressed;
    public static event Action OnInteractPressed;

    public static Vector2 MoveDirection { get; private set; }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) MoveDirection += Vector2.left;
        else if (Input.GetKey(KeyCode.D)) MoveDirection += Vector2.right;
        else MoveDirection = Vector2.zero;

        MoveDirection = MoveDirection.normalized;

        if (Input.GetKeyDown(KeyCode.Space)) OnJumpPressed?.Invoke();

        if (Input.GetKeyDown(KeyCode.F)) OnInteractPressed?.Invoke();
    }
}
