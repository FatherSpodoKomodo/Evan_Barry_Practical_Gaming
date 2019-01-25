﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    public float moveSpeed;
    public float turnSpeed;
    enum directionFacing {up, left, down, right};
    directionFacing thisDirection = directionFacing.up;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.W))
        {
            moveUp(moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft(moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDown(moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight(moveSpeed);
        }

        Camera.main.transform.position = transform.position + new Vector3(0, 3, -10);

    }

    /// <summary>
    /// Make the character turn/run/crawl forwards from the camera's perspective
    /// </summary>
    /// <param name="speed">Speed at which the character will move</param>
    private void moveUp(float speed)
    {
        //throw new System.NotImplementedException();

        //Code to check which direction the character is facing
        if (thisDirection == directionFacing.up)
        {
            moveForward(moveSpeed);
        }
        //Code to call a method to turn character in appropriate direction if not facing correct direction
        else
        {
            turn(directionFacing.up);
        }
    }

    /// <summary>
    /// Make the character turn/run/crawl left from the camera's perspective
    /// </summary>
    /// <param name="speed">Speed at which the character will move</param>
    private void moveLeft(float speed)
    {
        //throw new System.NotImplementedException();
        //Code to check which direction the character is facing
        if (thisDirection == directionFacing.left)
        {
            moveForward(moveSpeed);
        }
        //Code to call a method to turn character in appropriate direction if not facing correct direction
        else
        {
            turn(directionFacing.left);
        }
    }

    /// <summary>
    /// Make the character turn/run/crawl backwards from the camera's perspective
    /// </summary>
    /// <param name="speed">Speed at which the character will move</param>
    private void moveDown(float speed)
    {
        //throw new System.NotImplementedException();
        //Code to check which direction the character is facing
        if(thisDirection == directionFacing.down)
        {
            moveForward(moveSpeed);
        }
        //Code to call a method to turn character in appropriate direction if not facing correct direction
        else
        {
            turn(directionFacing.down);
        }
    }

    /// <summary>
    /// Make the character turn/run/crawl right from the camera's perspective
    /// </summary>
    /// <param name="speed">Speed at which the character will move</param>
    private void moveRight(float speed)
    {
        //throw new System.NotImplementedException();
        //Code to check which direction the character is facing
        if(thisDirection == directionFacing.right)
        {
            moveForward(moveSpeed);
        }
        //Code to call a method to turn character in appropriate direction if not facing correct direction
        else
        {
            turn(directionFacing.right);
        }
    }

    /// <summary>
    /// Make the character move forwards from the character's perspective
    /// </summary>
    /// <param name="speed">Speed at which the character will move</param>
    private void moveForward(float speed)
    {
        //throw new System.NotImplementedException();
        transform.position += speed * transform.forward * Time.deltaTime;
    }

    /// <summary>
    /// Make the character rotate to face diection they will move in
    /// </summary>
    /// <param name="direction">Direction will the character will face</param>
    private void turn(directionFacing direction)
    {
        //throw new System.NotImplementedException();
        if(direction == directionFacing.up)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0, transform.rotation.z);
            thisDirection = directionFacing.up;
        }

        if (direction == directionFacing.right)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 90, transform.rotation.z);
            thisDirection = directionFacing.right;
        }

        if (direction == directionFacing.down)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180, transform.rotation.z);
            thisDirection = directionFacing.down;
        }

        if (direction == directionFacing.left)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 270, transform.rotation.z);
            thisDirection = directionFacing.left;
        }
    }
}
