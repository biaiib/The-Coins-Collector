using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //permite configurar a troca de cenas

public class TelaFinal : MonoBehaviour
{
    public GameObject livemoedas;
    public GameObject livedistancia;
    public GameObject telaFinal;
    public GameObject fadeOut;
    void Start()
    {
        StartCoroutine(SequenciaFinal());
    }

   IEnumerator SequenciaFinal()
    {
        yield return new WaitForSeconds(3);
        livemoedas.SetActive(false);
        livedistancia.SetActive(false);
        telaFinal.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0); //a cena 0 (em File -> build settings) é o Menu; quando você perde, o jogo volta para o menu principal.

    }
}
