using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFromMenuToGameScene : MonoBehaviour {

	public void SwitchToGame() {
        Application.LoadLevel("Game");
    }
}
