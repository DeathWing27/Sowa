using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour {

    Logic logic;
   
    public bool gameOver = false;
    public string status = "Playing";

	// Use this for initialization
	void Start () {
        logic = this.GetComponent<Logic>();

	}
	
	// Update is called once per frame
	void Update () {
	
		checkstate () ;

	}

    void GameOver(){
        gameOver = true;
        logic.enabled = false;                
    }

    public void TryAgain(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

    //проверка победы
    bool CheckWin(int who){

        if ( logic.matr[0,0] == who && logic.matr[1,1]==who && logic.matr[2,2]==who ){
            return true;
        }
		if ( logic.matr[0,0] == who && logic.matr[1,0]==who && logic.matr[2,0]==who ){
			return true;
		}
		if ( logic.matr[0,1] == who && logic.matr[1,1]==who && logic.matr[2,1]==who ){
			return true;
		}
		if ( logic.matr[0,2] == who && logic.matr[1,2]==who && logic.matr[2,2]==who ){
			return true;
		}
		if ( logic.matr[0,0] == who && logic.matr[0,1]==who && logic.matr[0,2]==who ){
			return true;
		}
		if ( logic.matr[1,0] == who && logic.matr[1,1]==who && logic.matr[1,2]==who ){
			return true;
		}
		if ( logic.matr[2,0] == who && logic.matr[2,1]==who && logic.matr[2,2]==who ){
			return true;
		}
		if ( logic.matr[0,2] == who && logic.matr[1,1]==who && logic.matr[2,0]==who ){
			return true;
		}


        return false;
    }

    bool CheckNoWin(){

        bool haveEmpty = true;
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                if ( logic.matr[y,x] == -1 ){
                    haveEmpty = false;
                }
            }
        }

        return haveEmpty;
    }
	public void checkstate () {
		
		if ( CheckWin(1) ){
			status = "X wins";
			GameOver();
		}
		else if ( CheckWin(0) ){
			status = "O wins";
			GameOver();
		}
		else if ( CheckNoWin() ){
			status = "No win";
			GameOver();
		}



	}
}
