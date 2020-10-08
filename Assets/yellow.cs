using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    void OnTriggerEnter2D(Collider2D co)
    {
         if (co.gameObject.tag == "green")
        {
            transform.parent = co.gameObject.transform;   
        }
     
    }
    
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 8.0f)
        {
            dirRight = false;


        }
        if (transform.position.x <= -8)
        {
            dirRight = true;

        }
    }


}
