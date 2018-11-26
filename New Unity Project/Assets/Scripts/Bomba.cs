using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bomba : MonoBehaviour {
    public GameObject explosionPrefab;
    public LayerMask levelMask;
	// Use this for initialization
	void Start () {
        Invoke("Explode", 3f);
     


		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);


        GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Collider").gameObject.SetActive(false);
        Destroy(gameObject, .3f);

    }
  
}
