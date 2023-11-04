using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoObstaculos : MonoBehaviour
{
    public GameObject oJogador;
    public GameObject animacaoJogador;
    public AudioSource somBatida;
    public GameObject mainCam;
    public GameObject controleDaFase;

    void OnTriggerEnter(Collider other)
    {
        //quando o personagem bater em um obstaculo com esse script, sua movimentação corrida irá parar e trocar para a "Stumble Backwards" - personagem caindo

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        oJogador.GetComponent<Movimentacao>().enabled = false;
        animacaoJogador.GetComponent<Animator>().Play("Stumble Backwards");
        controleDaFase.GetComponent<DistanciaDaFase>().enabled = false;
        somBatida.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        controleDaFase.GetComponent<TelaFinal>().enabled = true;
    }
}
