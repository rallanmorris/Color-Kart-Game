using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWheelPortal : MonoBehaviour
{
	[SerializeField] string color;

	public void OnTriggerEnter(Collider other)
	{
		//Debug.Log("collision with " + other.gameObject.name);
		if(other.GetComponentInParent<PlayerColor>() != null)
		{
			//Debug.Log("calling set color");
			other.GetComponentInParent<PlayerColor>().SetColor(color);
		}
	}
}
