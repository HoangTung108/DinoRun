
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField]float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }
    void Update(){
     
        if (Control.scorevalue < 400){
            speed = -20f;
        }
        else if (Control.scorevalue < 1000)
        {
            speed = -30f;
        }
        else if (Control.scorevalue <5000){
            speed = -35f;
        }
        if (transform.position.x <-30){
            Destroy(gameObject);
        }
           rb.velocity = transform.right * speed;
    }

  
}
