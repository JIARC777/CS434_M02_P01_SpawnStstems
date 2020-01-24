using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iCopyable
{
    iCopyable Copy();
}

public enum AssetType
{
    drone,
    tank,
    sniper
}
