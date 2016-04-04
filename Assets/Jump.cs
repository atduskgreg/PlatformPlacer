using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpStrength;

	void Start () {
	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
		}
	}


}
