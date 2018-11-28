using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour {
    public int timer;
    public int maxDelay;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (timer < maxDelay)
        {
            timer++;
        }
        else
        {
            Application.LoadLevel("MainMenu");
            
            
        }
		
	}
}
