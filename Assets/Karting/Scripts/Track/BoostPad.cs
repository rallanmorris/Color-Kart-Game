using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class BoostPad : MonoBehaviour
{
	public int boostAmount = 3;
	public void OnTriggerEnter(Collider other)
	{
		if(other.GetComponentInParent<ArcadeKart>() != null)
		{
			other.GetComponentInParent<ArcadeKart>().Boost(boostAmount);
		}
	}
}
