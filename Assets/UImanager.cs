using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtscore;
    // Start is called before the first frame update
    void Start()
    {
        txtscore.text = "0";
    }

   public void updatescore(int scoreM)
    {
        txtscore.text = scoreM.ToString();
    }
}
