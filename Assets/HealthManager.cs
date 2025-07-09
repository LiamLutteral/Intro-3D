using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int Hp;
    public int maxHp;
    public UImanager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UImanager>();
        Hp = maxHp;
    }

    public void TakeDamage(int damagePoints)
    {
        if (Hp<= damagePoints)
        {
            SceneManager.LoadScene("FPS Parkur");
        }
        Debug.Log("Damage taken");
        Hp-= damagePoints;
        uiManager.UpdateHealth(Hp);
    }
 
}