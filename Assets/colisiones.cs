using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    public score Score;
    public mercaderia Mercaderia;
    private void Start()
    {
        Score = FindObjectOfType<score>();
        Mercaderia = GetComponent<mercaderia>();
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log('a');
        if (col.gameObject.name == "player")
        {
            Destroy(gameObject);
            Score.Addscore(Mercaderia.scorePoints);
        }
       
    }
}
