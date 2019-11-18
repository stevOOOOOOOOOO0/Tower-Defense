using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverBehaviour : MonoBehaviour
{

	private Color yellow;
	private Color oldColor;

	private void Start()
	{
		oldColor = GetComponent<Renderer>().material.color;
	}
	private void OnMouseEnter()
	{
		yellow = Color.yellow;
		yellow.a = .5f;
		GetComponent<Renderer>().material.color = yellow;
	}

	private void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = oldColor;
	}
}
