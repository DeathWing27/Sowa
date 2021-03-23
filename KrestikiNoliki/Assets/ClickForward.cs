using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickForward : MonoBehaviour {

	public int y;
	public int x;

	Logic logic;

	void Start () {
        logic = GameObject.Find("ticTacToe").GetComponent<Logic>();
	}
	
    public void Click(){               
        logic.Set( y,x );
    }

	// Update is called once per frame
	void Update () {
		
	}
}
