using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed;
    [SerializeField] TextMeshProUGUI scoreText;
    float currentScore = 0;
    float scoreIncrease = 10;
    [SerializeField] int scoreSpeedMultiplier = 10;
    void Start()
    {
        
        scoreText.text = currentScore.ToString();
        
    }
    // Start is called before the first frame update
    // void Start()
    // {
    //     InvokeRepeating(AddToScore, 1.0, 1.0);
    // }
    // void AddToScore(){
    //     currentScore +=10;
    // }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        AddToScore();
        gameIncrease();
       // randomSpawn();
    }
    public void AddToScore()
    {
        currentScore = currentScore + Time.deltaTime;
        scoreText.text = Mathf.RoundToInt(currentScore).ToString();
    }
    public void gameIncrease()
    {
         if(currentScore >= scoreSpeedMultiplier)
         {
             gameSpeed += 0.15f;
             scoreSpeedMultiplier += scoreSpeedMultiplier;
         }
    }
    // void randomSpawn()
    //   {
    //      int randomNumber = Random.Range(1,5);
    //      if(randomNumber == 1)
    //      {
    //          Obstacle.secondSpawn = 0.5f;
    //      }
    //      else if(randomNumber == 2)
    //      {
    //          Obstacle.secondSpawn = 0.6f;
    //      }
    //      else if(randomNumber == 3)
    //      {
    //          Obstacle.secondSpawn = 0.75f;
    //      }
    //      else if(randomNumber == 4)
    //      {
    //          Obstacle.secondSpawn = 0.85f;
    //      }
    //      Debug.Log(randomNumber);
    //   }
}
