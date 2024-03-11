using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour
{
    public GameObject player;
    public LayerMask whatIsGrounded;
    public Animator animate;
    [SerializeField] float playerHeight;
    [SerializeField] float jump;
  
    Rigidbody2D rb;
   
    bool ground;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        Cursor.visible = false;
       
    }
    void Update()
    {  
      
        animate.SetBool("isjump", false);
        ControlDino();
        LoadAnimateJump(); 
    
    }
    void OnTriggerEnter2D( Collider2D collision){
        if (collision.gameObject.tag == "Player"){
            animate.SetBool("collide",true);
            Invoke("StopTime", 0.3f);
        }
    }
    void ControlDino(){
         ground = Physics2D.Raycast( transform.position, Vector2.down, playerHeight, whatIsGrounded );
          if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && ground)
        {
           
            rb.velocity = new Vector2(0, rb.velocity.y);
            rb.AddForce( Vector2.up *jump, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(0, rb.velocity.y);
            rb.AddForce(Vector2.down * jump, ForceMode2D.Impulse);
        }
    }
    void LoadAnimateJump(){
        if(ground){
            animate.SetBool("isjump", false);
        }else{
            animate.SetBool("isjump", true);
        }
    }
    void StopTime(){
        Time.timeScale = 0;
    }
 
} 
