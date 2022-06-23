using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int Puntaje = 20;


    private void OnMouseDown()
    {

        gameScore.Score += Puntaje;

    }

   
}
