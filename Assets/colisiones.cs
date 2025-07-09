using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    public score Score;
    public mercaderia Mercaderia;
    void Start()
    {
        Score = FindObjectOfType<score>();
        Mercaderia = GetComponent<mercaderia>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            Score.AddScore(Mercaderia.scorePoints);
            Destroy(gameObject);
        }
       
    }
}
