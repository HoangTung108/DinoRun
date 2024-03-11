using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Backscroll : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private float width;
    private float scrollspeed = -10f;
    
    void Start()
    {
        collider = GetComponent <BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = collider.size.x * 2;
        rb.velocity = new Vector3(scrollspeed, 0, 0);
    }

    void Update()
    {
        Vector3 resetPosition = new Vector3(0, 0,0);
        if (transform.position.x < -width){
            resetPosition.x = width * 2f;
        }
        transform.position += (Vector3)resetPosition ;
}
}
