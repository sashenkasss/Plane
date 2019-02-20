using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collor : MonoBehaviour {

	public Sprite start;
	public Sprite end;

	void OnMouseDrag()
	{
		GetComponent<Image> ().sprite = end;
	}
	void OnMouseUp()
	{
		GetComponent<Image> ().sprite = start;
	}
}
