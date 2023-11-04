using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarTrecho : MonoBehaviour
{
    //script para gerar o mapa aleatoriamente
    
    public GameObject[] trecho;
    public int posZ = 50; //quero adicionar o primeiro trecho do mapa na posição z = 50
    public bool criarTrecho = false;
    public int numTrecho;
    void Update()
    {
        if (criarTrecho == false)
        {
            criarTrecho = true;
            StartCoroutine(gerarTrecho()); //coroutine cria delays (atrasos de tempo) entre a criação de um trecho e outro
        }
    }

    IEnumerator gerarTrecho() //cada um dos 3 trechos será gerado aleatóriamente
    {
        numTrecho = Random.Range(0, 3);
        Instantiate(trecho[numTrecho], new Vector3(0, 0, posZ), Quaternion.identity);
        posZ += 50;
        yield return new WaitForSeconds(2);
        criarTrecho = false;
    }

}
