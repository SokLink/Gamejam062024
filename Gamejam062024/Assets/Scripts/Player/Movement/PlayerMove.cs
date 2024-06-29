using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRb;
    [SerializeField, Range(0, 25f)] private float _speed;
    [SerializeField, Range(0, 100f)] private float _acceleration;


    private void FixedUpdate()
    {
        float targetSpeed = GameInputHandler.MoveDirection.x * _speed;

        float deltaSpeed = targetSpeed - _playerRb.velocity.x;

        float movement = (Mathf.Abs(deltaSpeed) * _acceleration) * Mathf.Sign(deltaSpeed);

        _playerRb.AddForce(movement * Vector2.right);
    }
}
