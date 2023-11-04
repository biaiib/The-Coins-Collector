using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteDaFase : MonoBehaviour
{
    //static permite qualquer stript interagir com essa variável; não aparece no painel inspector***

    public static float ladoEsquerdo = -3.5f;
    public static float ladoDireito = 3.5f;
    public float esquerdaInterna;
    public float direitaInterna;
    void Update()
    {
        esquerdaInterna = ladoEsquerdo;
        direitaInterna = ladoDireito;
    }
}
