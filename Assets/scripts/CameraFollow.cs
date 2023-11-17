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
        
        Vector3 targetposition = player.transform.position + new Vector3(0, 5, -10);
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref velocity, 0.1f);

    }
}
