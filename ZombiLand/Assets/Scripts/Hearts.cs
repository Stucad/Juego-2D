using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hearts : MonoBehaviour
{
    public GameObject[] heart;

    public int life;

    public GameObject[] enemys;

    
    public void Update()
    {
        
        if(life < 1)
        {

            Destroy(heart[0].gameObject);
            SceneManager.LoadScene("GameOver");
        }
        else if(life < 2)
        {

            Destroy(heart[1].gameObject);

        }
        else if(life < 3)
        {

            Destroy(heart[2].gameObject);

        }


    }

  
   
        
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "enemy")
        {

            life--;
            Destroy(collision.gameObject);
        }


    }
}
