using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeManagerTwo : MonoBehaviour
{
    public Vector3 startPosition;
    [SerializeField]
    private Vector3 homePosition;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello Welcome to the MY game **GO HOME** ");
        print("Instructions to play game:");
        print("Press UpArrow to move forward/ press DownArrow to move backward");
        print("My start position is:" + startPosition);
        print("My home position is:" + homePosition);
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
        CheckPlayerMovement(KeyCode.UpArrow,new Vector3(0,1,0));
        CheckPlayerMovement(KeyCode.DownArrow, new Vector3(0, -1, 0));
        CheckPlayerMovement(KeyCode.RightArrow, new Vector3(1, 0, 0));
        CheckPlayerMovement(KeyCode.LeftArrow, new Vector3(-1, 0, 0));
        CheckPlayerMovement(KeyCode.N, new Vector3(0, 0, 1));
        CheckPlayerMovement(KeyCode.M, new Vector3(0, 0, -1));

    }

    private void CheckPlayerMovement(KeyCode arrow,Vector3 value)
    {
        if (Input.GetKeyDown(arrow))
        {
            startPosition = startPosition + value;
            distance = homePosition - startPosition;
            print("Distance to travel is:" + distance.magnitude);
            /* float finalDistance = distance.magnitude;
           if (distance.y > 0)
                print("please press uparrow to move forward");
            else if (distance.y < 0)
                print("please press downarrow to move backward");*/

            if (startPosition == homePosition)
                print("***You reached home***");
        }
 
    }
}
