using System.Numerics;
using System.Threading.Tasks.Dataflow;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // int danio=1;
    // public Player playerscript;
    // Hara falta hacer una funcion en el player llamada Recibirdanio que haga que si mario recibe 2 de daño haga gameover
    int direccion = Random.Range(-1,2);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + direccion * Time.deltaTime, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Player") // o pies
        {
            
            Destroy(gameObject);
            //Destroy(collider.gameObject);
        }

        // if (collider.name == "cuerpo") {Recibirdanio(int danio)}
    }
}
