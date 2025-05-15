using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonar : MonoBehaviour
{
    public GameObject cuboprefab;
    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClonarCubo()
    {
        Instantiate(cuboprefab);
    }
}
