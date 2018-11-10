using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W)) this.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) this.transform.Translate(Vector3.left * 4f * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) this.transform.Translate(Vector3.back * 4f * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) this.transform.Translate(Vector3.right * 4f * Time.deltaTime);

    }
   
}
