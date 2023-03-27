using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);

        LiveAndScoreController.score++;
        Debug.Log("Score: " + LiveAndScoreController.score + "-----Lives: " + LiveAndScoreController.live);
    }
}
