using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioFase : MonoBehaviour
{
    public GameObject contRegressiva3;
    public GameObject contRegressiva2;
    public GameObject contRegressiva1;
    public GameObject contRegressivaVai;
    public GameObject fadeIn;
    public AudioSource contRegressivaFX;
    public AudioSource vaiFX;
    public AudioSource SoundTrack;
    void Start()
    {
        StartCoroutine(SequenciaContagem());
    }

    IEnumerator SequenciaContagem()
    {
        SoundTrack.Play();

        yield return new WaitForSeconds(1.5f);
        contRegressiva3.SetActive(true);
        contRegressivaFX.Play();

        yield return new WaitForSeconds(1);
        contRegressiva2.SetActive(true);
        contRegressivaFX.Play();

        yield return new WaitForSeconds(1);
        contRegressiva1.SetActive(true);
        contRegressivaFX.Play();

        yield return new WaitForSeconds(1);
        contRegressivaVai.SetActive(true);
        vaiFX.Play();
        
        //o jogador só pode se mover depois da contagem regressiva
        Movimentacao.podeMover = true; 
    } 
   
}
