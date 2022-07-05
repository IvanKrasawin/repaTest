using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public Stats stats;
    public Items item;
    public float StrangeLiquid = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            stats.Current_HP += StrangeLiquid;
            Destroy(GameObject.FindGameObjectWithTag("item"));
        }
    }
}
