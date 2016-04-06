using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float moveSpeed;
	public float jumpStrength;
	public LayerMask platformLayer;
	public Collider2D footCollider;

	void Start () {}
	
	void Update () {
		if(footCollider.IsTouchingLayers(platformLayer)){
			if(Input.GetKeyDown(KeyCode.Space)){
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
			}
			if(Input.GetKey(KeyCode.RightArrow)){
				GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveSpeed, ForceMode2D.Force);
			} else{
				if(Input.GetKey(KeyCode.LeftArrow)){
					GetComponent<Rigidbody2D>().AddForce(Vector2.left * moveSpeed, ForceMode2D.Force);
				}
			}
		}
	}
}
