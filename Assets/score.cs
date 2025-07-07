using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int scoreM;
    public UImanager UiManager;
    public mercaderia mercaderia;

    // Start is called before the first frame update
    void Start()
    {
        scoreM = 0;
        UiManager = FindObjectOfType<UImanager>();
    }

    // Update is called once per frame
    public void AddScore()
    {
        scoreM++;
        UiManager.updatescore(scoreM);
    }

    public void Addscore(int scorepoints)
    {
        scoreM += scorepoints;
        UiManager.updatescore(scoreM);
    }
}
