using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{
	public class KartItem : MonoBehaviour
	{
		Rigidbody playerRigidbody;
		ArcadeKart kart;
		[SerializeField] ArcadeKartPowerup booster;
		[SerializeField] ItemsManager itemsManager;

		public float delayBeforeItemPickup = 1;
		public int heldItem;
		public bool canPickup;
		private bool useItem;

		public Item itmUse;
		public int remainingItemUses;
		private bool cooldownDone;

		private void Start()
		{
			playerRigidbody = GetComponent<Rigidbody>();
			kart = GetComponent<ArcadeKart>();
			ResetItem();
			cooldownDone = true;
		}

		public void Update()
		{
			//Set item use input
			if (kart.fireInput > 0)
				useItem = true;
			else
				useItem = false;

			if (useItem && heldItem != -1 && cooldownDone)
			{
				ActivateItem();
				StartCooldown();
			}

		}

		public void ActivateItem()
		{
			remainingItemUses -= 1;
			if(itmUse.boost.Length > 0)
			{
				foreach(ItemBoostFunction itemBoost in itmUse.boost)
				{
					//boost
					kart.Boost(itemBoost.BoostAmt);
				}
			}

			if(remainingItemUses <= 0)
			{
				//Item is used up
				ResetItem();
			}
			cooldownDone = false;
		}

		public void StartCooldown()
		{
			StartCoroutine(Cooldown());
		}

		public IEnumerator Cooldown()
		{
			yield return new WaitForSecondsRealtime(3);
			cooldownDone = true;
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
			if (heldItem == -1 && canPickup)
			{
				canPickup = false;

				yield return new WaitForSeconds(delayBeforeItemPickup);

				int itemRand = UnityEngine.Random.Range(0, itemsManager.AllItems.Length);

				itmUse = itemsManager.AllItems[itemRand];

				heldItem = itemRand;
				remainingItemUses = itmUse.uses;
			}
		}
	}
}
