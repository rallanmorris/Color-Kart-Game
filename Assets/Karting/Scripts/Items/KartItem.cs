using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartItem : MonoBehaviour
{
	[SerializeField] GameObject kart;
	[SerializeField] ItemsManager itemsManager;

	public float delayBeforeItemPickup = 1;
	public int heldItem;
	public bool canPickup;
	private bool useItem;

	public Item itmUse;
	private int remainingItemUses;

	private void Start()
	{
		ResetItem();
	}

	public void Update()
	{
		//useItem = 
	}

	public void ResetItem()
	{
		itmUse = null;
		heldItem = -1;
		canPickup = true;
	}

	public void StartPickup()
	{
		StartCoroutine(PickUp());
	}

	public IEnumerator PickUp()
	{
		if(heldItem == -1 && canPickup)
		{
			canPickup = false;

			yield return new WaitForSeconds(delayBeforeItemPickup);

			int itemRand = Random.Range(0, itemsManager.AllItems.Length);

			itmUse = itemsManager.AllItems[itemRand];

			heldItem = itemRand;
			remainingItemUses = itmUse.uses;
		}
	}
}
