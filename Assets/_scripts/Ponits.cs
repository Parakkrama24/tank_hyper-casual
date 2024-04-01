using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ponits : MonoBehaviour
{
    private float score;
    private int integerScore;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int scoreSpeedMultipler = 5;
    void Start()
    {
        scoreText.text = "00";
    }

  
    void Update()
    {
        score += Time.deltaTime* scoreSpeedMultipler;
        //score = (int)score;
        integerScore= Mathf.RoundToInt(score);
        scoreText.text = integerScore.ToString();
    }
}
