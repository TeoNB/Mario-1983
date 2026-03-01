using UnityEngine;
using UnityEngine.InputSystem;



public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Move;
    public float velocidad;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(Move.x * velocidad, 0);
    }

    void OnMove(InputValue value)
    {
        Move = value.Get<Vector2>();
    }
}
