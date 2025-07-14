using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject barrilPrefab;

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
        // Aquí puedes agregar cualquier lógica que necesites para la clonación si quieres
    }

    public void clonarBarril()
    {
        for (int i = 0; i < 500; i++)
        {
            // Usar transform.position para obtener la posición
            Vector3 position = new Vector3(-2.5f, 17.31f, 36.2f) + Random.insideUnitSphere * 100f;

            // Instanciar el prefab en la misma posición con rotación cero (sin rotación)
            Instantiate(barrilPrefab, position, Quaternion.identity);
        }
    }

}
