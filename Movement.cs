using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public Transform RespawnPoint;
    public CharacterController controller;
    
    public float groundDistance = 0.4f;
    

    public float PlayerSpeed = 10f;
    public float jumpHeight = 2.0f;

    public float gravity = -10;
    bool isGrounded;

    Vector3 velocity;
    int maxjumps = 2;
    int currentjump=0;

    private float dashlength = 6.0f;
    private float dashSpeed = 1.0f;

    public Transform orientation;


     void Start()
    {  

    }

     void Update()
    {
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -0;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * PlayerSpeed * Time.deltaTime);

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

        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 Move = gameObject.transform.forward*dashlength;
            controller.Move(Move*1*dashSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
        }
    }
    
    

}