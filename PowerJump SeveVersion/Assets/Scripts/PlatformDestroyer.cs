using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
     GameObject destroyPoint;
    void Start()
    {
        destroyPoint = GameObject.Find("DestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
