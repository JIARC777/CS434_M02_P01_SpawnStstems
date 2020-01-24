using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public iCopyable copier;

    public Enemy SpwanEnemy(Enemy prototype)
    {
        copier = prototype.Copy();
        return (Enemy)copier;
    }
}
