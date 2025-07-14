using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{
    public score scoreManager;
    public GameObject UIInteractionMessage;
    GameObject currentInteractable = null;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<score>();
        UIInteractionMessage.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        mercaderia mercaderia = other.GetComponentInParent<mercaderia>();
        

        if (mercaderia)
        {
            currentInteractable = other.gameObject;
            UIInteractionMessage.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        mercaderia mercaderia = other.GetComponentInParent<mercaderia>();

        if (mercaderia)
        {
            UIInteractionMessage.SetActive(false);
            if (currentInteractable == other.gameObject) currentInteractable = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            mercaderia mercaderia = currentInteractable.GetComponentInParent<mercaderia>();
            Instantiator instantiator = currentInteractable.GetComponentInParent<Instantiator>();

            if (instantiator)
            {
                instantiator.clonarBarril();
            }

            scoreManager.AddScore(mercaderia.scorePoints);
            Destroy(currentInteractable);
            currentInteractable = null;
            UIInteractionMessage.SetActive(false);
        }
    }
}