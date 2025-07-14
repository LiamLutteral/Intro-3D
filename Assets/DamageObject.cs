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
        Debug.Log("Hola");
        if (col.gameObject.name == "Hibox")
        {
            healthManager.TakeDamage(damagePoints);
        }
    }
}