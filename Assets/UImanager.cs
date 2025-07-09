using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtscore;
    public TextMeshProUGUI txtHp;
   
    void Start()
    {
        txtscore.text = "0";
    }

   public void UpdateScore(int scoreM)
    {
        txtscore.text = scoreM.ToString();
    }

    public void UpdateHealth(int health)
    {
        txtHp.text = health.ToString();
    }
}
