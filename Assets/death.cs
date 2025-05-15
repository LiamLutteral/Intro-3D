using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
    
{
    public float Death = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < Death)
        {
            Debug.Log("respawn");
            SceneManager.LoadScene("FPS Parkur");
        }

    }
}
