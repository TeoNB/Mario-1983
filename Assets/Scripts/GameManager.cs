using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Camera camPrincipal;
    [SerializeField] private float empuje;

    int vidas = 3;
    int score = 0;  
    public TextMeshProUGUI scoreText;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        camPrincipal = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = camPrincipal.WorldToViewportPoint(transform.position);

        if (posicion.x > 1)
        {
            transform.position = camPrincipal.ViewportToWorldPoint(new Vector3(empuje, posicion.y, posicion.z));
        }
        else if (posicion.x < 0)
        {
            transform.position = camPrincipal.ViewportToWorldPoint(new Vector3(1 - empuje, posicion.y, posicion.z));
        }

	}

    public void addScore(int score)
    {
        score++;
        scoreText.text = "Score: " + this.score;
	}

    public void PerderVida(int cantidad)
    {
        vidas -= cantidad;
        Debug.Log("Vidas restantes: " + vidas);
        if (vidas <= 0)
        {
            GameOver();
        }
	}

	void GameOver()
    {
       scoreText.text = "Game Over! Final Score: " + score;
	}

}
