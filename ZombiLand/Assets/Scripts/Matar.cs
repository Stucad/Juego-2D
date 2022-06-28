using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{

    public int life;
    private void OnMouseDown()
    {

        life--;

        if(life < 0)
        {
            
            Destroy(gameObject);

        }

    }

}
