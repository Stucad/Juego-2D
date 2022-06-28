using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    

    public void EcenaJuego()
    {

        SceneManager.LoadScene("Juego");

    }

    public void EcenaRules()
    {

        SceneManager.LoadScene("Rules");

    }

    public void EcenaMenu()
    {

        SceneManager.LoadScene("Menu Inicio");

    }
}
