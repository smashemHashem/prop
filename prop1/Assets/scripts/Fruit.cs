using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    //add prefabs for obstacle spawning in inspector adds to list
[SerializeField] GameObject[] obstaclePrefab;
    //how often obstacle spawns in seconds 
[SerializeField]float  SecondSpawn = 0.5f;

//state variable????
//magic fix for method



    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(ObstacleSpawn());

    }

    // Update is called once per frame

    
    
    IEnumerator ObstacleSpawn()
    {
        while(true)
        // {  int i = Random.Range(1,4);
        // if(i == 1)
        // {
        //     var wanted = -2f;
        // }
        // else if (i == 2)
        // {
        //     var wanted = 0f;
        // }
        // else if (i == 3)
        // {
        //     var wanted = 2f;
        // }
        {
            var wanted = Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(obstaclePrefab[Random.Range(0, obstaclePrefab.Length)], position, Quaternion.identity);
            // yield return new WaitforSeconds(SecondSpawn);
            Destroy(gameObject, 5f);
        }
    }
    }

