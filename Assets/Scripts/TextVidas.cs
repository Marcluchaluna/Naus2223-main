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
        textoVidas.text = "Vidas:" + vidas;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActualizarVidas()
    {
        vidas--;
        textoVidas.text = "Vidas:" + vidas;
        if (vidas == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PassarAGameOver();
        }
        
    }
    public void SumarExtra()
    {
        vidas++;
        textoVidas.text = "Vidas:" + vidas;
    }
    public void InicialitzarVidas()
    {
        vidas = 3;
        textoVidas.text = "Vidas:" + vidas;

    }
}
