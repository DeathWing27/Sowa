using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenereator : MonoBehaviour
{
    public GameObject platfrom;
    public Transform generationPoint;
    public float distanceBetween;
    
    private float platforWidth;

    void Start()
    {
       
        platforWidth = platfrom.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x )
        {
           transform.position = new Vector3(transform.position.x +distanceBetween + platforWidth + Random.Range(-1,2),Random.Range(-6f,-4f),transform.position.z);

            Instantiate(platfrom,transform.position,transform.rotation);
        }
       
      
    }
    
}
