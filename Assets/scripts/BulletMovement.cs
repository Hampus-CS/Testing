using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    public void Fire(Vector3 direction)
    {

        RB = GetComponent<Rigidbody>();
        RB.AddForce(direction, ForceMode.Impulse);
    
    }
    
    //
    void OnCollisionEnter(Collision collision)
    {

        //Om man vill se i konsolen att skottet träffar så använder man: Debug.Log("Träff");

        GameObject otherGameObject = collision.gameObject;
        EnemyScript hitEnemy = otherGameObject.GetComponent<EnemyScript>();
        
        if(hitEnemy != null)
        {
            hitEnemy.TakeDamage();   
        }
        Destroy(gameObject);

    }

}
