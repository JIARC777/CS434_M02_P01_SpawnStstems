using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClient : MonoBehaviour
{

    public Drone drone;
    public Sniper sniper;
    public Tank tank;
    public EnemySpawner spawner;
    public bool loadFromMemory; 

    private Enemy spawn;
    private int droneIncrementor = 0;
    private int sniperIncrementor = 0;
    private int tankIncrementor = 0;
   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (loadFromMemory)
            {
                GameObject droneClone = Instantiate(Resources.Load("Drone", typeof(GameObject))) as GameObject;
                droneClone.name = "Drone_Clone_" + ++droneIncrementor;
                Debug.Log("Loaded from memory");
                droneClone.transform.Translate(Vector3.forward * droneIncrementor * 1.5f);

            } else
            {
                spawn = spawner.SpwanEnemy(drone);
                spawn.name = "Drone_Clone_" + ++droneIncrementor;
                spawn.transform.Translate(Vector3.forward * droneIncrementor * 1.5f);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (loadFromMemory)
            {
                GameObject sniperClone = Instantiate(Resources.Load("Sniper", typeof(GameObject))) as GameObject;
                sniperClone.name = "Sniper_Clone_" + ++droneIncrementor;
                Debug.Log("Loaded from memory");
                sniperClone.transform.Translate(Vector3.forward * droneIncrementor * 1.5f);

            }
            else
            {
                spawn = spawner.SpwanEnemy(sniper);
                spawn.name = "Sniper_Clone_" + ++sniperIncrementor;
                spawn.transform.Translate(Vector3.forward * sniperIncrementor * 1.5f);
            }   
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (loadFromMemory)
            {
                GameObject tankClone = Instantiate(Resources.Load("Tank", typeof(GameObject))) as GameObject;
                tankClone.name = "Tank_Clone_" + ++tankIncrementor;
                Debug.Log("Loaded from memory");
                tankClone.transform.Translate(Vector3.forward * droneIncrementor * 1.5f);

            } else
            {
                spawn = spawner.SpwanEnemy(tank);
                spawn.name = "Tank_Clone_" + ++sniperIncrementor;
                spawn.transform.Translate(Vector3.forward * tankIncrementor * 1.5f);
            }
            
        }
    }
}
