using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    private int index = 0;

    public void FullSlot()
    {
        isFull[index] = true;
        index += 1;
    }
}
