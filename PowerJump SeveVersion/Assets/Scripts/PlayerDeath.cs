using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath: MonoBehaviour
{
    public Transform respawnpoint;

private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Granice")
        {
           Respawn();
           
            
        }
     }

     public void Respawn()
     {
      SceneManager.LoadScene("SampleScene");

     }
    





}
