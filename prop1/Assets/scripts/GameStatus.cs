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
    }
}
