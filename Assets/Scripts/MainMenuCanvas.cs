using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuCanvas : MonoBehaviour {

	public Canvas mainMenu;
	public Button play;
	public Button highScore;
	public Button exit;
	public Text getReady;

	// Use this for initialization
	void Start () {

		mainMenu = mainMenu.GetComponent<Canvas>();
		play = play.GetComponent<Button>();
		highScore = play.GetComponent<Button>();
		exit = exit.GetComponent<Button>();

		getReady.text = "";


		
	}
	
	// Update is called once per frame
	void Update () {		
	}

	public void startGame(){

		mainMenu.gameObject.SetActive (false);
		getReady.text = "Take a deep breath";

		Invoke ("setThree", 2.0f);

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
}
