using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public float smooth = 2.5f; // сглаживание при следовании за персонажем
    public float offset; // значение смещения (отключить = 0)
	private GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void Update(){
        
        
        transform.position = new Vector3(player.transform.position.x+offset,transform.position.y,transform.position.z);
         
    }

}