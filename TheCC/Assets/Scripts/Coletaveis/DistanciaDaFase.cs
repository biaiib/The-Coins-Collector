using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanciaDaFase : MonoBehaviour
{
    //script para mudar a distancia da corrida no display da tela

    public GameObject displayDis;
    public GameObject distanciaFinal;
    public int disCorrida;
    public bool addDis = false;
    public float delayDis = 0.35f;
    void Update()
    {
        if (addDis == false)
        {
            addDis = true;
            StartCoroutine(AdicionarDis());
        }
    }

    IEnumerator AdicionarDis()
    {
        disCorrida += 1;
        displayDis.GetComponent<TextMeshProUGUI>().text = "" + disCorrida;
        distanciaFinal.GetComponent<TextMeshProUGUI>().text = "" + disCorrida;
        yield return new WaitForSeconds(delayDis);
        addDis = false;
    }
}
