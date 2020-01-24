using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
	public NPCFactory factory;
	private NPC farmer;
	private NPC shopOwner;
	private NPC beggar;
	private NPC villager;

	public void SpawnVillagers()
	{
		beggar = factory.GetNPC(NPCType.Beggar);
		shopOwner = factory.GetNPC(NPCType.Shopowener);
		farmer = factory.GetNPC(NPCType.Farmer);
		villager = factory.GetNPC(NPCType.Villager);

		beggar.Speak();
		shopOwner.Speak();
		farmer.Speak();
		villager.Speak();
	}
}
