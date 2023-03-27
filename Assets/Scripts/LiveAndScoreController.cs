using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveAndScoreController : MonoBehaviour
{
    public static int score;
    public static int live;


    public void Start()
    {
        score = 0;
        live = 30;
        Debug.Log("Score: " + score + "-----Lives: " + live);
    }
}
