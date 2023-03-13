using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    float ForwardForce = 9000;
    public float SideForce = 100;
    float UpForce = 8000;
    public bool CanJump = true;
    public bool CanMove = false;

    // Start is called before the first frame update
    void Start()
    {
        CanMove = true;
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (CanMove == true)
        {
           rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.Force);
        } 

        if (Input.GetKey("a"))
        {
            if (CanJump == true)
            {
                rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("d"))
        {
            if (CanJump == true)
            {
                rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("w"))
        {
            if (CanJump == true)
            {
                rb.AddForce(0, UpForce, 0);
                CanJump = false;
            }
        }

        if (rb.position.y <  -1.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            CanJump = true;
        }
    }
}
