using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReloadScene : MonoBehaviour
{
   public HeroController hc;

   public EnemyScript EnemySc;
   public GameObject butStar;
   private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hc.enabled == false || EnemySc.enabled == false )
        {
            timer++;
            butStar.SetActive(true);
            if (Input.anyKey && timer>200)
            {
                SceneManager.LoadScene(0);
                timer=0;
            }
            
        }
    }

    

}
