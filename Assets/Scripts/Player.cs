using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyPressed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= 5;
      
    }



    private void FixedUpdate()
    {
        if (jumpKeyPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 3, ForceMode.VelocityChange);

        jumpKeyPressed = false;
        }
        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y , 0);
     
    }

    
}
