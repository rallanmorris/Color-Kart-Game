using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KartGame.KartSystems;


public class ItemUIHandle : MonoBehaviour
{
	private bool shuffleSprite;
	public float timeBtwShuffle;
	public Sprite[] allItemGraphics;
	public Sprite EmptyItem;

	public Image img;
	public KartItem kart;

    // Start is called before the first frame update
    void Start()
    {
		shuffleSprite = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(kart.heldItem == -1)
		{
			if(kart.canPickup)
			{
				img.sprite = EmptyItem;
			}
			else
			{
				if(shuffleSprite)
				{
					Invoke("Shuffle", timeBtwShuffle);
					shuffleSprite = false;
				}
			}
		}
		else
		{
			img.sprite = kart.itmUse.visual;
		}
    }

	void Shuffle()
	{
		img.sprite = allItemGraphics[UnityEngine.Random.Range(0, allItemGraphics.Length)];
		shuffleSprite = true;
	}
}
