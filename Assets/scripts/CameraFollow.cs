using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // FixedUpdate is called on a set amout of frames
    void FixedUpdate()
    {
        
        Vector3 playerposition = player.transform.position + new Vector3(0, 5, -10);
        transform.position = Vector3.SmoothDamp(transform.position, playerposition, ref velocity, 0.1f);

    }
}
