using UnityEngine;
using UnityEngine.UI;

public class HeroController : MonoBehaviour
{
     
    
   
    public Slider slider;

    private float currentValue = 1f;

    public bool IsOnPlace = false;
   public EnemyScript es;
    public float timer;
    public GameObject Enemy;

    public GameObject flash;

    public GameObject panel;
    public GameObject text;
    
    public float CurrentValue {
        get {
            return currentValue;
        }
        set {
            currentValue = value;
            slider.value = currentValue;
           
           
        }
     }

    

    private void Start ()
    {
        CurrentValue = 1f;

          
    }

    


   private void Update()
    {
            
            Attack();
        

           if (IsOnPlace == true)
          {
           // flash.enabled = false;
              

              timer ++;   
              if (timer>=100)
              {
                   this.transform.Translate(-1,0,0);  
                   Enemy.transform.Translate(-1,0,0);                
             IsOnPlace = false;
             flash.SetActive(false);
           CurrentValue -= 0.1f;
           timer = 0;
              }     
          }    
 if (CurrentValue<=0)
        {
            text.SetActive(true);
            panel.SetActive(true);
            

           es.enabled = false;
          
        }
            
        
    }

    public void Attack() 
    {

         if (Input.GetMouseButtonDown(0)&&timer==0)
         {
             flash.SetActive(true);
            
            this.transform.Translate(1,0,0); 
            Enemy.transform.Translate(1,0,0);             
          IsOnPlace = true;
          
          }

    }

        
}

