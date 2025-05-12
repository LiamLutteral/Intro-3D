using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClone : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public GameObject cylinderPrefab;
    GameObject clone;
    public int min;
    public int max;
    int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomClone()
    {
        randomNumber = Random.Range(min, max);

        switch (randomNumber)
        {
            case 1:
                clone = spherePrefab;
                break;

            case 2:
                clone = cubePrefab;
                break;

            case 3:
                clone = cylinderPrefab;
                break;
        }

        Instantiate(clone);
    }
}
