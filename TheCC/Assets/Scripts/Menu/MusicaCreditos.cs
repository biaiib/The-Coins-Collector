using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaCreditos : MonoBehaviour
{
    public AudioSource Creditos;

    private void Start()
    {
        Creditos.Play();
    }
}
