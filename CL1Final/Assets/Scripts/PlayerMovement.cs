using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 10f;
    Vector2 lastClickedPos;

    bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))                                                             //checks if right click has been pressed
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);                   //sets the target position based on the last right clicked pos using the position on screen 
            isMoving = true;                                                                        // sets isMoving to true
        }

        if(isMoving && (Vector2)transform.position != lastClickedPos)                               //check if isMoving is true and if the current position is not the same as target position 
        {
            float step = playerSpeed * Time.deltaTime;                                              //normalises player movement speed 
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);     //moves the player from their current position to the target position at assigned player speed
        }
        else
        {
            isMoving = false;
        }
    }
}
