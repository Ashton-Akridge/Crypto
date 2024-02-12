using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public GameObject item;
    public int amount;
    public Interact pickupFromInteract;
    [SerializeField] Inventory inventory;


    private void OnEnable()
    {
        item.SetActive(false);
        
        Interact check = GetComponent<Interact>();
        if (check)
        {
            pickupFromInteract = check;
            pickupFromInteract.GetInteractEvent.HasInteracted += InteractPickup;
        }
        else
        {
            Interact addComp = this.gameObject.AddComponent<Interact>();
            pickupFromInteract = addComp;
            pickupFromInteract.GetInteractEvent.HasInteracted += InteractPickup;
        }
    }
    private void OnDisable()
    {
        if (pickupFromInteract)
        {
            pickupFromInteract.GetInteractEvent.HasInteracted -= InteractPickup;
        }
    }

    public void InteractPickup()
    {
        AddItem(pickupFromInteract.GetPlayer);
        
    }

    public void AddItem(Player player)
    {
        item.SetActive(true);
        inventory.FullSlot();
    }
}