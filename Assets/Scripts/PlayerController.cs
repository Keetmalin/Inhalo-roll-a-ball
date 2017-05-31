using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody rb;
	private int count;
	public Text healthText;

	public Text scoreText;

	// Use this for initialization
	void Start () {
	
		healthText.text = "";
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetText ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//physics properties
	void FixedUpdate(){


		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetText ();
		}
	
	}

	void SetText(){
	
		scoreText.text = "Score: " + (count*10).ToString ();
	}

}
