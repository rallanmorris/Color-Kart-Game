using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class ItemBlock : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.GetComponentInParent<KartItem>() != null)
		{
			if(other.GetComponentInParent<KartItem>().heldItem == -1 && other.GetComponentInParent<KartItem>().canPickup)
			{
				//Start item pickup
				other.GetComponentInParent<KartItem>().StartPickup();
				Destroy(this.gameObject);
			}
		}
	}
}
