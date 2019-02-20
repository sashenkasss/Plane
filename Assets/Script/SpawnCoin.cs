using UnityEngine; 
using System.Collections;
public class SpawnCoin : MonoBehaviour { 

	public GameObject coin; 
	void Start () { 
		StartCoroutine(Spawn()); 
	} 
	IEnumerator Spawn()
	{ 
		while (ConstComponent.Game) {
			GameObject obj = Instantiate (coin, new Vector2 (Random.Range (-2.5f, 2.5f), Random.Range (0, 4.5f)), Quaternion.identity); 
			yield return new WaitForSeconds (Random.Range (15f, 30f)); 

		} 
	}


}