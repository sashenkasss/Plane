using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour {

    public Transform player;
    private const float maxMoveX = 12.5f;
    public static Vector3 generatorPos = new Vector3(8.33f, 1.84f, 0f);
    int randomLevel;
    public List<GameObject> levels;
    bool checkCreate = true;
    private float minX, maxX;
	public GameObject coins;

    private void Start()
    {
        minX = Camera.main.ScreenToWorldPoint(transform.position).x;
        maxX = -minX;
        Debug.Log(minX + " and " + maxX);
    }

    void FixedUpdate ()
    {
        transform.position = new Vector3(transform.position.x - 1 * Time.deltaTime*3, transform.position.y, transform.position.z);
        if (checkCreate)
        {
            if (transform.position.x <= minX)
            {
                randomLevel = Random.Range(0, 2);
                GameObject obj = Instantiate(levels[randomLevel], new Vector3(generatorPos.x, generatorPos.y, 87f), Quaternion.identity);
				GameObject coin = Instantiate (coins, new Vector3 (generatorPos.x, generatorPos.y, 87f), Quaternion.identity);
				coin.transform.SetParent(obj.transform);
				checkCreate = false;
            }
        }

        if (transform.position.x <= minX - 40f)
        {
            Destroy(gameObject);
        }
	}

    
}
