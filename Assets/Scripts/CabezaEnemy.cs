using UnityEngine;

public class CabezaEnemy : MonoBehaviour
{
	public GameObject Enemigo; 
	float bounceForce = 10f;
	public GameManager GameManager;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();

			if (rb != null)
			{
				rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
			}
			GameManager.addScore(10);
			Destroy(Enemigo);
		}
	}
}
