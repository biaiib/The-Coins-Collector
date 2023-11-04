using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FuncoesMenu : MonoBehaviour
{
    public void jogar()
    {
        SceneManager.LoadScene(1); //a cena 1 refere-se ao nível da floresta.
    }

    public void creditos()
    {
        SceneManager.LoadScene(2);
    }
    public void sair()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

}

