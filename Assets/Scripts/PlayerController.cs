using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody rb;
	private int count;
	public Text healthText;
	public Text scoreText;


	//menu controllers
	public Canvas mainMenu;
	public Button play;
	public Button highScore;
	public Button exit;
	public Text getReady;

	// Use this for initialization
	void Start () {
	
		healthText.text = "";
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetText ();

		//for main menu
		mainMenu = mainMenu.GetComponent<Canvas>();
		play = play.GetComponent<Button>();
		highScore = play.GetComponent<Button>();
		exit = exit.GetComponent<Button>();

		getReady.text = "";
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


	//for main menu
	public void startGame(){

		mainMenu.gameObject.SetActive (false);
		getReady.text = "Take a deep breath";

		Invoke ("setThree", 1.0f);

	}

	void setThree(){
		getReady.text = "3";
		Invoke ("setTwo", 1.0f);
	}

	void setTwo(){
		getReady.text = "2";
		Invoke ("setOne", 1.0f);
	}

	void setOne(){
		getReady.text = "1";
		Invoke ("Blow", 1.0f);
	}

	void Blow(){
		getReady.text = "Blow";
		Invoke ("clearText", 1.0f);
	}

	void clearText(){
		getReady.text = "";
	}

	void Exit(){
		Application.Quit();
	}

}
