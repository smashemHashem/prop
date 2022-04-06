using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //cache?
     Rigidbody2D myRigidBody2D;
    int currentLane = 1;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        // transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log();
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
         turnLeft();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            turnRight();
        }
    }
    private void turnLeft()
    {
        if (currentLane == 1)
        {
            transform.position = new Vector2 (-2f,transform.position.y);
            currentLane = 0;
        }
        else if(currentLane == 2)
        {
            transform.position = new Vector2 (0f,transform.position.y);
            currentLane = 1;
        }
    }
    private void turnRight()
    {
        if (currentLane == 0)
        {
            transform.position = new Vector2 (0f,transform.position.y);
            currentLane=1;
        }
       else if(currentLane == 1)
        {
            transform.position = new Vector2 (2f,transform.position.y);
            currentLane = 2;
        }
    }
}
