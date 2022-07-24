using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
	[SerializeField] GameObject playerSkin;
	[SerializeField] GameObject kartSkin;

	public string playerColor;

	[SerializeField] Material red;
	[SerializeField] Material yellow;
	[SerializeField] Material green;
	[SerializeField] Material blue;
	[SerializeField] Material purple;


	public void SetColor(string color)
	{
		playerColor = color;

		//Set skin to match color
		switch(color)
		{
			case "red":
				playerSkin.GetComponent<Renderer>().material = red;
				kartSkin.GetComponent<Renderer>().material = red;
				break;
			case "yellow":
				playerSkin.GetComponent<Renderer>().material = yellow;
				kartSkin.GetComponent<Renderer>().material = yellow;
				break;
			case "green":
				playerSkin.GetComponent<Renderer>().material = green;
				kartSkin.GetComponent<Renderer>().material = green;
				break;
			case "blue":
				playerSkin.GetComponent<Renderer>().material = blue;
				kartSkin.GetComponent<Renderer>().material = blue;
				break;
			case "purple":
				playerSkin.GetComponent<Renderer>().material = purple;
				kartSkin.GetComponent<Renderer>().material = purple;
				break;
			default:
				break;
		}
		//Debug.Log("Turning player " + color);
	}
}