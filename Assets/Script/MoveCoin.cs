using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoin : MonoBehaviour {
	[SerializeField] 
	private float speed = 8f;
	bool flag = true;
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 0)
			flag = false;
		if(flag)
		transform.position -= new Vector3 (0, speed * Time.deltaTime, 0);
		else
			transform.position += new Vector3 (0, speed * Time.deltaTime, 0);
		if (transform.position.y >= 4.5f)
			flag = true;
	}
}
