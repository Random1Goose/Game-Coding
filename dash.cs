using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    private float dashlength = 6.0f;
    private float dashSpeed = 1.0f;
    public CharacterController controller;
    Vector3 velocity;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 Move = gameObject.transform.forward*dashlength;
            controller.Move(Move*1*dashSpeed);
        }
    }
}
