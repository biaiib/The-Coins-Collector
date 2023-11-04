using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarObjeto : MonoBehaviour
{
    //script para girar objetos (moedas e maçãs)
    public int velocidadeDeGiro = 2;

    void Update()
    {
        transform.Rotate(0, velocidadeDeGiro, 0, Space.World);
    }
}
