using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeGameManager : MonoBehaviour
{
    public Vector2 startPosition;
    [SerializeField]
    private Vector2 homePosition;
    private Vector2 distance;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello Welcome to the MY game **GO HOME** ");
        print("Instructions to play game:");
        print("Press UpArrow to move forward/ press DownArrow to move backward");
        print("My start position is:" + startPosition);
        print("My home position is:"+ homePosition);
        distance = homePosition - startPosition;
        print("The distance to travel is:" + distance.magnitude);
        float finalDistance = distance.magnitude;
        if (finalDistance > 0)
            print("Move Forward");
        else if (finalDistance < 0)
            print("Move Backward");
        else if (finalDistance == 0)
            print("** Destination reached **");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPosition = startPosition+new Vector2 (0,1);
            distance = homePosition - startPosition;
            print("Distance to travel is:" +distance);
            float finalDistance=distance.magnitude;
            if (finalDistance > 0)
                print("please press uparrow to move forward");
            else if (finalDistance < 0)
                print("please press downarrow to move backward");
            else if (finalDistance == 0)
                print("***You reached home***");
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector2(0, -1);
            distance = homePosition - startPosition;
            print("Distance to travel is:" + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
                print("please press downarrow to move forward"+ finalDistance);
            else if (finalDistance < 0)
                print("please press uparrow to move backward");
            else if (finalDistance == 0)
                print("***You reached home***");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPosition = startPosition + new Vector2(-1, 0);
            distance = homePosition - startPosition;
            print("Distance to travel is:" + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
                print("please press rightarrow to move right"+ finalDistance);
            else if (finalDistance < 0)
                print("please press leftarrow to move left");
            else if (finalDistance == 0)
                print("***You reached home***");
        }
            // print("Up arrow is pressed");   
            if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startPosition = startPosition+new Vector2(1,0);
            distance = homePosition - startPosition;
            print("Distance to travel is:" + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
                print("please press rightarrow to move right");
            else if (finalDistance < 0)
                print("please press leftarrow to move left");
            else if (finalDistance == 0)
                print("***You reached home***");


        }
    }
}
