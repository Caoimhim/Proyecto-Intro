using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
