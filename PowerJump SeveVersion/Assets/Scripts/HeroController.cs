using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeroController : MonoBehaviour
{
     private Rigidbody2D rb;
     public Slider slider; 
     [Range(0,50)]
     public float JumpStrength;
    public float speed = 10;
    public bool IsGrounded = false;
    
    
    
    void Awake()
    { 
       rb = GetComponent<Rigidbody2D>();
       
            
    }

    // Update is called once per frame
    void Update()
    {     
     
        Jump();
     }
     void Jump()
     {
       if ((Input.GetMouseButton(0)&& IsGrounded == true))
        {
            
        JumpStrength+=0.9f;
        if ( JumpStrength>=50)
        {
            JumpStrength = 50;
        }
        slider.value = JumpStrength;
        
        
        }    
        
           
     if (Input.GetMouseButtonUp(0))
     {
         rb.AddForce(new Vector2(JumpStrength*speed, JumpStrength*15));
         JumpStrength = 0;
         slider.value = 0;    
         IsGrounded = false;
     }
     }
     void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Ground")
        {
            IsGrounded = true;
        }
        else IsGrounded = false;
        
     }
     
    

     
}
