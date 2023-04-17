using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaExtra : MonoBehaviour
{
    // Start is called before the first frame update
    private float _vel = 5f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         ApareceCorazon();
        
    }
    public void ApareceCorazon()
    {

        Vector2 novaPos = transform.position;

        Vector2 direccio = new Vector2(1f, 0f);

        novaPos = novaPos + direccio * _vel * Time.deltaTime;

        transform.position = novaPos;

        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.x > minPantalla.x)
        {
            //Debug.Log("Ha sortit fora.");
            // GameObject és l'objecte actual que té aquest script (com si fos un "this").
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "NauJugador")
        {


            Destroy(gameObject);
        }
    }
}
