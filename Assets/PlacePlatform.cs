using UnityEngine;
using System.Collections;

public class PlacePlatform : MonoBehaviour {

	public GameObject platform;
	public float offset = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.B)){
			int xDir = (int)Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x);


			Instantiate(platform, new Vector2(transform.position.x + offset*xDir, transform.position.y - 0.5f) ,Quaternion.identity);
		}
	}
}
