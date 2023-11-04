using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movimentacao : MonoBehaviour
{
    public float velocidadeFrente = 10;
    public float velocidadeHorizontal = 4;
    //public float velocidadeVertical = 3;
    public static bool podeMover = false;
    public bool pulando = false;
    public bool descendo = false;
    public GameObject objetoJogador;
    void Update() //os dados das variáveis vão ser atualizados (updated) constantemente 
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidadeFrente, Space.World);
        if (podeMover == true)
        {
            //movimento esquerda
            if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
            {
                if (this.gameObject.transform.position.x > LimiteDaFase.ladoEsquerdo)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * velocidadeHorizontal);
                }

            }

            //movimento direita
            if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
            {
                if (this.gameObject.transform.position.x < LimiteDaFase.ladoDireito)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * velocidadeHorizontal);
                }
            }

            if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.Space))))
            {
                if (pulando == false)
                {
                    pulando = true;
                    objetoJogador.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(SequenciaDePulo());
                }
            }
        }

        //movimentação de pulo (animação e vetores)
        if (pulando == true)
        {
            if (descendo == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }

            if (descendo == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }

        }

    }
    //quando o pulo era feito muitas vezes, o codigo abaixo fazia com que a personagem ficasse subindo até não tocar mais o chão


    /*IEnumerator SequenciaDePulo()
    {
        yield return new WaitForSeconds(0.45f);
        descendo = true;
        yield return new WaitForSeconds(0.45f);
        pulando = false;
        descendo = false;
        objetoJogador.GetComponent<Animator>().Play("Fast Run");
    }*/

    //resolução: variável "alturaInicial"
    IEnumerator SequenciaDePulo()
    {
        float alturaInicial = transform.position.y;
        yield return new WaitForSeconds(0.45f);
        descendo = true;
        yield return new WaitForSeconds(0.45f);
        pulando = false;
        descendo = false;
        transform.position = new Vector3(transform.position.x, alturaInicial, transform.position.z);
        objetoJogador.GetComponent<Animator>().Play("Fast Run");
    }
}

