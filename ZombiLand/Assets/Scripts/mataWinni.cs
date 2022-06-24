using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mataWinni : MonoBehaviour
{
    private Hearts Hearts;
    public Hearts Life;

    private void OnMouseDown()
    {
        if(Life.life < 1)
        {

            Destroy(Hearts.heart[0].gameObject);

        }
        else if(Life.life < 2)
        {

            Destroy(Hearts.heart[1].gameObject);

        }
        else if(Life.life < 3)
        {

            Destroy(Hearts.heart[2].gameObject);

        }
    }


}
