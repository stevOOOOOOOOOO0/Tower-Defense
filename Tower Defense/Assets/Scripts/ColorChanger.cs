using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
	
	private Color yellow;
	private Color oldColor;
	
	public void ChangeToYellow()
	{
		oldColor = GetComponent<Renderer>().material.color;
		yellow = Color.yellow;
		yellow.a = .5f;
		GetComponent<Renderer>().material.color = yellow;
	}

	public void ReturnColor()
	{
		GetComponent<Renderer>().material.color = oldColor;
	}
}
