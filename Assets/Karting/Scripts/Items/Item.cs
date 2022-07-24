using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
	public string name;
	public string description;
	public int uses;

	public ItemBoostFunction[] boost;

	public Sprite visual;
}
