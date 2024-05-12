using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Manager : MonoBehaviour
{
    public GameObject inventorySelect;


    public void Start()
    {
        inventorySelect.SetActive(false);
    }

    public void InventoryWindowOn()
    {
        if (inventorySelect.activeSelf == false) inventorySelect.SetActive(true);
        else inventorySelect.SetActive(false);
    }
}
