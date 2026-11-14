using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float worldScrollingSpeed = 0.2f;
    
    void Start()
    {
        if (instance == null) { instance = this; }
    }

}
