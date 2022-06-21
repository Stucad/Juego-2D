using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioFX;
    public float volumen = 1f;

    private void OnMouseDown()
    {

        AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
        Destroy(gameObject, 0.1f);
      
    }
}
