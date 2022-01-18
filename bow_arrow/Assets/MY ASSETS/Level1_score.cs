using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1_score : MonoBehaviour
{   
    public static Level1_score instance;

    public Text scoreText;

    int score = 0;
    int tarcze_quantity = 0;

    private void Awake() 
    {
        instance = this;
    }
 
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    public void Add2Points()
    {
        score += 2;
        scoreText.text = score.ToString() + " POINTS";
        tarcze_quantity += 1;
    }

    public void Add4Points()
    {
        score += 4;
        scoreText.text = score.ToString() + " POINTS";
        tarcze_quantity += 1;
    }

    public void Add6Points()
    {
        score += 6;
        scoreText.text = score.ToString() + " POINTS";
        tarcze_quantity += 1;
    }

    public void Add8Points()
    {
        score += 8;
        scoreText.text = score.ToString() + " POINTS";
        tarcze_quantity += 1;
    }
       
    public void Add10Points()
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
        tarcze_quantity += 1;
    }

    void Update()
    {

        if (tarcze_quantity >= 10)
        {
            if (score >= 60)
            {

            FindObjectOfType<FirstPersonController>().CursorUnlock();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            score = 0;
            tarcze_quantity = 0;
            scoreText.text = score.ToString() + " POINTS";
            }

            else
            {
             
             tarcze_quantity -= 1;
             FindObjectOfType<GameManager>().EndGame();

            }
        }
    }
}
