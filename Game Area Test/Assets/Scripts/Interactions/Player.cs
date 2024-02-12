using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject ChestText;
    [SerializeField] GameObject orientation;

    //Player Variables
    void Update()
    {
        PlayerInteract();
        
    }

    public void PlayerInteract()
    {
        Vector3 origin = transform.position;
        float sphereRadius = 1.0f; // Change this as needed depending on tolerance you want
        Vector3 direction = orientation.transform.forward;
        RaycastHit hit;
        float maxCastDist = 2.0f; // Change this as needed depending on how close the object must be for interaction

        if (Physics.SphereCast(origin, sphereRadius, direction, out hit, maxCastDist))
        {
            Interact interactScript = hit.transform.GetComponent<Interact>();
            if (interactScript)
                ChestText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                // Logic for checking whether object hit is interactable, etc using hitInfo.
                if (interactScript) interactScript.CallInteract(this);
            }
            
        }
        else
        {
            ChestText.SetActive(false);
        }
        
    }
}