using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int scorecoin;

    [SerializeField] Text ScoreCounter;
    

    // Update is called once per frame
    void Update()
    {
       ScoreCounter.text = scorecoin.ToString();
    }
    private void OnTriggerEnter2D(Collider2D col)
     {
        if (col.gameObject.tag==("Coin"))
        {
           scorecoin++;
           Destroy(col.gameObject);
        }

     }
}
