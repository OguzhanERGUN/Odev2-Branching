using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Destroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 31 )
        {
            Destroy(gameObject);

        }
        else if (transform.position.z <= -10)
        {
            Destroy(gameObject);
            LiveAndScoreController.live--;
            Debug.Log("Score: " + LiveAndScoreController.score + "-----Lives: " + LiveAndScoreController.live);


        }
        else if (transform.position.x <-35)
        {
            Destroy(gameObject);
            LiveAndScoreController.live--;
            Debug.Log("Score: " + LiveAndScoreController.score + "-----Lives: " + LiveAndScoreController.live);

        }

    }
}
