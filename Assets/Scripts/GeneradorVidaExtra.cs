using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVidaExtra : MonoBehaviour
{
    public GameObject _VidaExtra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IniciGeneraVidaExtra()
    {
        // Param1: Nom mètode a cridar.
        // Param2: temps fins a cridar-se.
        // Param3: temps entre repeticions
        InvokeRepeating("CreaVidaExtra", 10f, 10f);
    }

    public void AturaGenerarVidaExtra()
    {
        CancelInvoke("CreaVidaExtra");
    }

    private void CreaVidaExtra()
    {
        GameObject nauEnemic = Instantiate(_VidaExtra);

        // Anem a situar en una posició aleatòria (però a la dreta) l'enemic creat.

        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f));
        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1f, 1f));

        // Trobem posició y aleatoria entre el marge inferior i superior de la pantalla.
        float posicioHorizontalComponentY = Random.Range(minPantalla.y, maxPantalla.y);

        nauEnemic.transform.position = new Vector2(minPantalla.x, posicioHorizontalComponentY);
    }
}
