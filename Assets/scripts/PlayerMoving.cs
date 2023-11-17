using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody RB;
    
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && RB.velocity.y == 0)
        {
            RB.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }

    }
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            RB.AddForce(new Vector3(0, 0, 75));
        }
        if (Input.GetKey(KeyCode.W))
        {
            RB.AddForce(new Vector3(0, 0, 25));
        }



        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            RB.AddForce(new Vector3(75, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(new Vector3(25, 0, 0));
        }



        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            RB.AddForce(new Vector3(0, 0, -75));
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            RB.AddForce(new Vector3(0, 0, -25));
        }



        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            RB.AddForce(new Vector3(-75, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(new Vector3(-25, 0, 0));
        }

    }

}
