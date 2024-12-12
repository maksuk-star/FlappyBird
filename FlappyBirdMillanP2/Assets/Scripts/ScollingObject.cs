using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScollingObject : MonoBehaviour
{
    private Rigidbody rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
