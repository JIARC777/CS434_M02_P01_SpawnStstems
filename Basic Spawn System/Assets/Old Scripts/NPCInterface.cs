using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPC
{
	void Speak();
}

public enum NPCType
{
	Farmer,
	Beggar,
	Shopowener,
	Villager
}