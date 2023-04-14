using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextVidas : MonoBehaviour
{
    public int vidas = 3;

    public TextMeshProUGUI textoVidas;

    public GameObject _ExplosioPrefab;

    public GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActualizarVidas()
    {
        vidas--;
        if (vidas == 0)
        {
            


            _gameManager.GetComponent<GameManager>().PassarAGameOver();
            // La nave ha perdido todas sus vidas
            // Aquí puedes destruir la nave o mostrar una pantalla de game over
        }
        textoVidas.text = "Vidas:" + vidas;
    }
}
