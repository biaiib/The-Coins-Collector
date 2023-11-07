using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMoedas: MonoBehaviour
{
    public static int contadorMoedas;
    public GameObject displayContadorMoedas;
    public GameObject MoedasFinal;

    void Start()
    {
        contadorMoedas = 0; //inicializa o contador para zero ao iniciar o jogo.
    }
    void Update()
    {
        displayContadorMoedas.GetComponent<TextMeshProUGUI>().text = "" + contadorMoedas;
        MoedasFinal.GetComponent<TextMeshProUGUI>().text = "" + contadorMoedas;
    }
}
