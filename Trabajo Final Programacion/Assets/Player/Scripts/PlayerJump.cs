using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 6f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verifica si se presiona la barra espaciadora y si el jugador está en el suelo
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Aplica una fuerza hacia arriba
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private bool IsGrounded()
    {
        // Verifica si el jugador está en el suelo

        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
