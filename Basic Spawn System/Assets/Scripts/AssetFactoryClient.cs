using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetFactoryClient : MonoBehaviour
{
    public AssetFactory factory;

    public void spawn(AssetType type) 
    {
        factory.GetEnemy(type);
    }
    public void Update()
    {
        
        if (Input.GetKey("d"))
        {
            spawn(AssetType.drone);
        }
        if (Input.GetKey("t"))
        {
            spawn(AssetType.tank);
        }
        if (Input.GetKey("s"))
        {
            spawn(AssetType.sniper);
        }
    }
}
