using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int min;
    public int max;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clonar(GameObject objeto)
    {
        Instantiate(objeto);
    }
}
