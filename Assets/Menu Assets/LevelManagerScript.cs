using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {
	public void SwitchScene(string scene) {
		Debug.Log ("Attempting to load \"" + scene + "\" scene");
		Application.LoadLevel(scene);
	}
	public void QuitGame(){
		Debug.Log ("Attempting to quit game");
		Application.Quit();
	}
}
