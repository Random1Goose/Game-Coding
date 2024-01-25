using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yaxix : MonoBehaviour
{
    public float jumpHeight = 2.0f;
    public float gravity = -5;
    Vector3 velocity;
    public CharacterController controller;
    int maxjumps = 2;
    int currentjump=0;

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
             if (currentjump!=maxjumps)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
                currentjump+=1;
            }
            
        }

        if (Input.GetButtonDown("jump reset"))
        {
            if (currentjump==maxjumps)
                {
                    currentjump=0;
                }
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
