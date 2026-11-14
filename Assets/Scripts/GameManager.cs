using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float worldScrollingSpeed = 0.2f;
    public Text scoreText;
    private float score;
    
    void Start()
    {
        if (instance == null) { instance = this; }
    }


    void FixedUpdate()
    {
        score += worldScrollingSpeed;
        scoreText.text = score.ToString("0");
    }
}
