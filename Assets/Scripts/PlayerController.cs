using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    CharacterController controller;

    [SerializeField]
    float speed;

    float gravity = -9.81f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = x * transform.right + z * transform.forward;

        controller.Move(move * speed);
        velocity.y = gravity;
        controller.Move(velocity);
    }
    
}
