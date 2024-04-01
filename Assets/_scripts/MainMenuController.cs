using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private tankController tankContollerScript;
    private bool isGameOver=false;
    [SerializeField] private GameObject GameOverPanel;
    void Start()
    {
        
    }


     void Update()
    {
        isGameOver = tankContollerScript.isgameOver;
        if(isGameOver)
        {
            gameOver();
            isGameOver =false;
        }
    }

    private void gameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }
}//class
