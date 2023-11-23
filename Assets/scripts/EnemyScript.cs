using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   
    int hp = 3;

    public void TakeDamage()
    {

        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }

    }

}
