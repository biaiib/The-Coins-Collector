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
    void Update()
    {
        displayContadorMoedas.GetComponent<TextMeshProUGUI>().text = "" + contadorMoedas;
        MoedasFinal.GetComponent<TextMeshProUGUI>().text = "" + contadorMoedas;
    }
}
