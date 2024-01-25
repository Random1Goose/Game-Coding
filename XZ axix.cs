using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XZaxix : MonoBehaviour
{
    public float PlayerSpeed = 10f;
    public CharacterController controller;
    Vector3 velocity;

    
    void Update()
    {
        if(velocity.y < 0)
        {
            velocity.y = -0;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * PlayerSpeed * Time.deltaTime);
    }
}
