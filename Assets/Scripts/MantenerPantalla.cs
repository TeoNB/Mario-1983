using UnityEngine;

public class MantenerPantalla : MonoBehaviour
{
    private Camera camPrincipal;
    [SerializeField] private float empuje;

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

    
}
