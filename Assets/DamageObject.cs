using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageObject : MonoBehaviour
{
    public HealthManager healthManager;
    public int damagePoints;


    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            healthManager.TakeDamage(damagePoints);
            
        }
    }
}