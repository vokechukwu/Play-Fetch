using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    //public float rightBoundary = 10.0f;
    //public float leftBoundary = -10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //here we transform the players position by getting the x value and ensuring that it is less than -10 
        if (transform.position.x < -xRange)
        {
            //recall that our objective is to constrain the player to stay within the boundaries of the game screen
            //so to do that, we take his position and tie it to less than -10
            //then we multiply it by new Vector3 which is where we want him to return to whenever he attempts 
            //to stray off the screen. You'll also notice that his y and z axis do not change. Only x does.
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            //recall that our objective is to constrain the player to stay within the boundaries of the game screen
            //so to do that, we take his position and tie it to less than -10 and 10. Thus creating a range
            //then we multiply it by new Vector3 which is where we want him to return to whenever he attempts 
            //to stray off the screen. All else is same as above.
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //To do for later: Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
