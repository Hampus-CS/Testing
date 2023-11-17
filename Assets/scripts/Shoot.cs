using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Rigidbody RigBod;
    
    // Start is called before the first frame update
    void Start()
    {
        
        RigBod = GetComponent<Rigidbody>();

        RigBod.velocity = new Vector3(10, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
