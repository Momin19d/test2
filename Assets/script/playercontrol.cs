using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class playercontrol : MonoBehaviour {
	public float speed;
	private int count;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		//SetCountText ();
	}
	void FixedUpdate () 
	{
		float moveVertical = Input.GetAxis("Vertical");
		float moveHorizontal = Input.GetAxis("Horizontal");	

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			//SetCountText ();
		}
	}
/*	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();

	}*/
}
