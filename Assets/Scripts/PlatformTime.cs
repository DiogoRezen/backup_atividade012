using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTime : MonoBehaviour
{
    public Rigidbody2D rb;
    //public float tempo = 1f;
   
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Equals("Knight"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.mass = 50f;
            rb.gravityScale = 0.5f;
        }
    }
}
