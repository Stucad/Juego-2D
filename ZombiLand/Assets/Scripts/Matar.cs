using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{

    public int vida;
    public GameObject[] enemigos;
    public Animator animacion;
    private void OnMouseDown()
    {

        vida--;

        if(vida <= 0)
        {

            animacion.SetBool("Explocion", true);
                
        }

    }

    public void MyOnDestroy()
    {

        Destroy(gameObject);

    }

}
