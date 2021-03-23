using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour{
	
    public List<Text> texts;
    Logic logic;
    Text tex;
    GameObject tryAgain;
    GameManager manager;

    // Use this for initialization
    void Start()
    {
        logic = this.GetComponent<Logic>();
        tex = GameObject.Find("TextInfo").GetComponent<Text>();
        tryAgain = GameObject.Find("ButtonAgain");
        tryAgain.SetActive( false );
        manager =this.GetComponent<GameManager>();
    }

    void Display()
    {
		for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {                                
                if (logic.matr [y, x] == 0){
					texts [y * 3 + x].text = "O";
                } else if (logic.matr [y, x] == 1){
					texts [y * 3 + x].text = "X";
                } else if (logic.matr [y, x] == -1){
					texts [y * 3 + x].text = "";
                }
            }
        }
    }
	
    // Update is called once per frame
    void Update()
    {
        Display();
        tex.text = manager.status;

        if ( manager.gameOver == true ){           
            DisableButtons();
            tryAgain.SetActive( true );
        }

    }

    void DisableButtons(){

        for (int i = 0; i < texts.Count; i++)
        {
            texts[i].transform.parent.GetComponent<Button>().interactable = false;
        }

    }
}
