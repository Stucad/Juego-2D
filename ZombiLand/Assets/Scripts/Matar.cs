using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{

    public int vida;
    
    public Animator animacion;
    private void OnMouseDown()
    { 

      animacion.SetBool("Muerte", true);         
       
    }

    public void MyOnDestroy()
    {

        Destroy(gameObject);

    }

}
