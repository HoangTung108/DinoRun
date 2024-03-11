using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wayscroll : MonoBehaviour 
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private float speed ;
    private float width;
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = collider.size.x*15;
    }
    void Update()
    {
        if (Control.scorevalue < 400){
            speed = -15f;
        }
        if (Control.scorevalue > 400 && Control.scorevalue < 1000){
            speed = -25f;
        }
        if (Control.scorevalue>1000 && Control.scorevalue< 5000){
            speed = -30f;
        }
        rb.velocity = new Vector3(speed, 0,0);
        Vector3 inputvector = new Vector3(0,0,0);
        
        if (transform.position.x < -width){
            inputvector.x = width* 1.8f;
        }
        transform.position += (Vector3)inputvector;
    }
}
