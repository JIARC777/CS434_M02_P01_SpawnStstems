using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public NPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                NPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                NPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowener:
                NPC shopOwner = new Shopowener();
                return shopOwner;
            case NPCType.Villager:
                NPC villager = new Villager();
                return villager;
        }
        return null;
    }
}
