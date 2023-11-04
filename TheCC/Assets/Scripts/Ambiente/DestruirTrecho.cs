using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirTrecho : MonoBehaviour
{
    //resolvi deixar esse script em aberto pois o tempo de velocidade do personagem e de destruição de trechos estavam difíceis de se alinharem;
    //os trechos se destroem muito rapido e o personagem acaba correndo no ar. 

    /*public string nomeParente;
    void Start()
    {
        nomeParente = transform.name;
        StartCoroutine(DestruirClone());
    }

    IEnumerator DestruirClone()
    {
        yield return new WaitForSeconds(120);
        if (nomeParente == "Trecho(Clone)") 
        {
            Destroy(gameObject);
        }
    }*/
}
