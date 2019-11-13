using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehaviour : MonoBehaviour
{

	private Vector3 mousePosition;
	
	private void OnMouseDrag()
	{
		mousePosition.Set(Input.mousePosition.x / Screen.width, 5f, Input.mousePosition.z / Screen.height);
		gameObject.transform.position = Vector3.Lerp(transform.position, mousePosition, .2f);
	}
}
