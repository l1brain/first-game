using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController controller;
    int lane = 1;
  //  private int playerPosition = 1;
    const float laneDistance = 1.0f; // lane length
    float speed = 7.0f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        //Info from inputs where we should be
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeLane(false);
            Debug.Log(transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(transform.position.z);
            ChangeLane(true);
        }



        //Calculate where we should be in the future
        Vector3 targetPosition = transform.position.z * Vector3.forward;
        if (lane == 0)
            targetPosition += Vector3.left * laneDistance;
        else if (lane == 2)
            targetPosition += Vector3.right * laneDistance;

        //Calculate our move delta
        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * speed;
        moveVector.y = -0.1f;
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);
        // speed= speed + Time.deltaTime;

    }
    void ChangeLane(bool goingRight)
    {
        lane += (goingRight) ? 1 : -1;
        lane = Mathf.Clamp(lane, 0, 2);
    }


}
