using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody RigBod;
    
    // Start is called before the first frame update
    void Start()
    {
        
        RigBod = GetComponent<Rigidbody>();

        RigBod.velocity = new Vector3(0, 0, 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
