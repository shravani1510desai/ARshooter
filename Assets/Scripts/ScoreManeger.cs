﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public static int score;
    


    Text text;
    // Start is called before the first frame update

    void Awake()
    {

        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "score: " + score;
       
    }
    
}
