using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssetFactory : MonoBehaviour
{
    public EnemySpawner spawner;
    // text for scorekeeping
    public Text droneCount;
    public Text tankCount;
    public Text sniperCount;

    Enemy drone;
    Enemy tank;
    Enemy sniper;
    // Create reference to an enemy spawner (does not need to be in the scene)
    
    // Keep track of spawns (purely for case of initial spawn)
    int numberOfDroneSpawns = 0;
    int numberOfTankSpawns = 0;
    int numberOfSniperSpawns = 0;

    public Enemy GetEnemy(AssetType type)
    {
        // creating local references to the object that the factory can use to copy
        
        switch (type)
        {
            case AssetType.drone:
                // case for no objects in scene - load from memory
                if (numberOfDroneSpawns < 1)
                {
                    drone = Instantiate(Resources.Load("Drone", typeof(Enemy))) as Enemy;
                    numberOfDroneSpawns++;
                    droneCount.text = numberOfDroneSpawns.ToString();
                    return drone;
                    
                }
                // otherwise use the object's copy method to create a version of itself
                else
                {
                    numberOfDroneSpawns++;
                    droneCount.text = numberOfDroneSpawns.ToString();
                    // Use Copy instead of trying to create a reference to the EnemySpawner class since we cannot use the unity Inspector to create a references
                    return spawner.SpwanEnemy(drone);
                }
            case AssetType.tank:
                // case for no objects in scene - load from memory
                if (numberOfTankSpawns < 1)
                {
                    tank = Instantiate(Resources.Load("Tank", typeof(Enemy))) as Enemy;
                    numberOfTankSpawns++;
                    tankCount.text = numberOfTankSpawns.ToString();
                    return tank;

                }
                // otherwise use the object's copy method to create a version of itself
                else
                {
                    numberOfTankSpawns++;
                    tankCount.text = numberOfTankSpawns.ToString();
                    return spawner.SpwanEnemy(tank);
                }
            case AssetType.sniper:
                // case for no objects in scene - load from memory
                if (numberOfSniperSpawns < 1)
                {
                    sniper = Instantiate(Resources.Load("Sniper", typeof(Enemy))) as Enemy;
                    numberOfSniperSpawns++;
                    sniperCount.text = numberOfSniperSpawns.ToString();
                    return sniper;

                }
                // otherwise use the object's copy method to create a version of itself
                else
                {
                    numberOfSniperSpawns++;
                    sniperCount.text = numberOfSniperSpawns.ToString();
                    return spawner.SpwanEnemy(sniper);
                }

        }
        return null;
    }
}
