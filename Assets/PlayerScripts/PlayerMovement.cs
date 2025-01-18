using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;

    private Vector2 _moveDir;

    public InputActionReference move;

    private void Update()
    {
        _moveDir = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(_moveDir.x * moveSpeed, _moveDir.y * moveSpeed);
    }
}
