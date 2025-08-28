using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Configurações de pulo")]
    public float jumpForce = 5f; // Força do pulo
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Apertar espaço OU clique esquerdo do mouse
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Zera a velocidade antes de aplicar a força (deixa o pulo mais responsivo)
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
