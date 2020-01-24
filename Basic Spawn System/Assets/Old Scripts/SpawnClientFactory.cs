using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClientFactory : MonoBehaviour
{
    public NPCSpawner spawner;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawner.SpawnVillagers();
        }    
    }
}
