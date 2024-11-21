using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        Vector2 move = new Vector3(moveInput.x, moveInput.y) * speed * Time.deltaTime;
        transform.position += new Vector3(move.x,move.y,0);
    }
}
