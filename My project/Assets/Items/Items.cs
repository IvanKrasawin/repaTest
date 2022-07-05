using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public Stats stats;
    public Items item;
    public float StrangeLiquid = 15f;
    public float Thongs = 0.02f;
    public float Crocs = 0.3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            stats.Current_HP += StrangeLiquid;
            stats.Attack_Speed += Thongs;
            stats.Speed += Crocs;
            Destroy(GameObject.FindGameObjectWithTag("item"));
        }
    }
}
