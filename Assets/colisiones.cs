using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    public score score;
    private void Start()
    {
        score = FindObjectOfType<score>();
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log('a');
        if (col.gameObject.name == "player")
        {
            Destroy(gameObject);
            score.Addscore();
        }
       
    }
}
