using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour {

	
    public Transform Spawnpoint;
    public GameObject Prefab;
    private float nextActionTime = 0.0f;
    public float interpolationPeriod = .1f;

    void OnTriggerEnter(){
        if (Input.GetKey(KeyCode.Y))
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation); 
        }
    }

    void Update()
    {
        
        if (Time.time > nextActionTime )
        {
            nextActionTime = Time.time + interpolationPeriod;
            OnTriggerEnter();
        }

        
    }
    // Update is called once per frame

}
