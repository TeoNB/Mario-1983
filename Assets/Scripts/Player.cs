using UnityEngine;
using UnityEngine.InputSystem;



public class Player : MonoBehaviour
{
	//Referencia a los componentes necesarios
	PlayerInput playerInput;
	Rigidbody2D rb;

	//Variables para el movimiento
	Vector2 Move;
    public float velocidad;
    
    public GameManager GameManager;

	//Variables para el salto
	float jumpForce;
    bool isGrounded;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        jumpForce = 7f;
	}

    // Update is called once per frame
    void Update()
    {
        Move = playerInput.actions["Move"].ReadValue<Vector2>();    

        
	}

    void FixedUpdate()
    {
		rb.linearVelocity = new Vector2(Move.x * velocidad, rb.linearVelocity.y);

	}



	void OnMove(InputValue value)
    {
        Move = value.Get<Vector2>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Salto");
		if (context.performed && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Suelo"))
        {
            isGrounded = true;
        }

	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            
        }
	}
	private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isGrounded = false;
        }
	}
}
