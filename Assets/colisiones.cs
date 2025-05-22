using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log('a');
        if (col.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
       
    }
}
