using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int scoreM;
    public UImanager UiManager;

    void Start()
    {
        scoreM = 0;
        UiManager = FindObjectOfType<UImanager>();
    }
    public void AddScore()
    {
        scoreM ++;
        UiManager.UpdateScore(scoreM);
        Debug.Log ("la vieja de oneto");
    }

    public void AddScore(int scorePoints)
    {
        scoreM += scorePoints;
        UiManager.UpdateScore(scoreM);
        Debug.Log ("la vieja de manu");
    }
}
