using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;
    
    [SerializeField]
    GameObject aimObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        Vector3 aimPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, -Camera.main.transform.position.z));

        aimObject.transform.position = aimPos;

        Vector3 direction = aimPos - transform.position;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //spawna skott
            GameObject bulletGameObject = Instantiate(bullet, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
            BulletMovement bulletMove = bulletGameObject.GetComponent<BulletMovement>();
            
            //
            bulletMove.Fire(direction);
        }

    }

}
