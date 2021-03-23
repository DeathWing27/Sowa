using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
	GameManager gm;
    public int[,] matr = new int[,]
    {
        //-1 пустое место    0-O  1-X
        { -1, -1, -1 },
        { -1, -1, -1 },
        { -1, -1, -1 },
    };
	void Awake () {
	gm	 = this.GetComponent<GameManager> ();


	}
    void Start()
    {
		
    }
	
    void Update()
    {
       
    }

    public void Set(int y, int x ){

        if ( matr[y,x] == -1 ){
            matr[y,x] = 1;
			gm.checkstate ();
			if (gm.gameOver == false) {
				AIMove();
			}
            
        }
    }

    //ф-я хода искуственного интелекта
    void AIMove(){

	#region centr(O)
		if (matr [1, 1] == -1) {
			matr [1, 1] = 0; 
			return;

		}
		if (matr[2,0] == 1 && matr [2,1] == 1 && matr [2,2] == -1) {
			matr[2,2] = 0;
			return;
		}
		if (matr [0, 0] == -1) {
			matr [0, 0] = 0; 
			return;
			
		}

		if (matr [0,1]== 0 && matr [2,1]==-1) {
			matr[2,1] = 0;
			return;
		}
		if (matr[1,0]==1 && matr[0,1] == -1) {
			matr[0,1] =0;	
			return;
			
		}
		if (matr[0,0]==1 && matr [0,1]==-1) {
			matr[0,1] =0;	
			return;
		}
		if (matr[0,1]==0 && matr [0,2]==-1 ) {
			matr[0,2]=0;
			return;
		}
		if (matr[0,2]==1 && matr [1,2]==-1) {
			matr[1,2]=0;
			return;
		}
		if (matr [0, 0] == 0 && matr [1,1] == 0 && matr [2,2] == -1) {
			matr [2, 2] = 0; 
			return;

		}
		if (matr [0, 0] == 0 && matr [1,1] == 0 && matr[2,2]== 1 && matr [1,0]==-1) {
			matr [1,0] = 0; 
			return;

		}
		if (matr [0, 0] == 0 && matr [1,0] == 0 && matr [2,0]==-1 ) {
			matr [2,0] = 0;
		}
		if (matr [0, 0] == -1 && matr [1,1] == -1 && matr[2,2]== 0 ) {
			
		}
	#endregion 
//		if (matr [2, 0] == -1) {
//			matr [2, 0] = 0; 
//			return;
//
//		}
//		if (matr [1, 1] == 1) {
//			matr [0, 0] = 0; 
//			return;
//
//		}
		if (matr [0, 0] == -1) {
			matr [0, 0] = 0; 
			return;
		}



//		for (int y = 0; y < 3; y++) {
//			for (int x = 0; x < 3; x++) {
//				if (matr [y, x] == -1) {
//					matr [y, x] = 0;
//					return;
//				}
//			}
//        





		}
	}

	

