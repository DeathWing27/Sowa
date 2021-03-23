
using UnityEngine;
using UnityEngine.UI;


public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public float StartAtt;
    public float RandomDote = 5;

    public int Health;
    public int NumOfHealth;
    public Image [] hearts; 
     public Sprite Heart;

     public  HeroController hs;
     public GameObject Hero;

     public float timer;
     public GameObject flash2;

     public bool IsOnPlace = false;

     public GameObject panel;
    public GameObject text;


     
    void Start()
    {
         
    }

    // Update is called once per frame
  public  void Update()
    {
        
        StartAtt+=0.2f;
        if (IsOnPlace == true)
          {
              timer ++;   
              if (timer>=20)
              {
                  this.transform.Translate(-1,0,0); 
            Hero.transform.Translate(-1,0,0); 
            flash2.SetActive(false);
            timer = 0;
            IsOnPlace = false;
        
    }
          }
       
         if (StartAtt>=RandomDote)
         {
             
             EnemyAttack();
            
             
             StartAtt=0;
             RandomDote = Random.Range(40,60); 
         }
         
      if (NumOfHealth<=0)
 {
     Dead();
 }

              
    void EnemyAttack()
    
    {

            this.transform.Translate(1,0,0); 
            Hero.transform.Translate(1,0,0); 
             flash2.SetActive(true);
             IsOnPlace = true;
   NumOfHealth-=1;


for (int i = 0; i < hearts.Length; i++)
{
    if (i < NumOfHealth)
    {
        hearts[i].enabled = true;
       
     } else {
         hearts[i].enabled = false;
       
     }

    
}




    }
    
}

    private void Dead()
    {
          text.SetActive(true);
         panel.SetActive(true);
        

        this.enabled = false;
        hs.enabled = false;
        
    }
}
