using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarMoeda : MonoBehaviour
{
    public AudioSource somMoeda;
    void OnTriggerEnter(Collider other)
    {
        somMoeda.Play();
        ContadorMoedas.contadorMoedas += 1;
        this.gameObject.SetActive(false); 
    }
}
