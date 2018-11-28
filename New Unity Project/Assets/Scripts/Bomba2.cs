using System.Collections; using System.Collections.Generic;
using UnityEngine;
using System;

public class Bomba2 : MonoBehaviour {
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public bool exploded = false;
    GameObject referenceObject;
    Player referenceScript;
    public GameObject destroyBlocks;
    // Use this for initialization
    void Start() {
        Invoke("Explode", 3f);
	referenceObject = GameObject.FindGameObjectWithTag("Player2");
	referenceScript = referenceObject.GetComponent<Player>();

    }

    // Update is called once per frame
    void Update() {
    }

    void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity); 

        GetComponent<MeshRenderer>().enabled = false; 
        exploded = true;
        //transform.Find("Collider").gameObject.SetActive(false); 
        Destroy(gameObject, .3f); 

        StartCoroutine(CreateExplosions(Vector3.forward));
        StartCoroutine(CreateExplosions(Vector3.right));
        StartCoroutine(CreateExplosions(Vector3.back));
        StartCoroutine(CreateExplosions(Vector3.left));
	referenceScript.iBombs++;


    }
    public IEnumerator CreateExplosions(Vector3 direction)
    {

        for (int i = 1; i < 3; i++)
        {

            RaycastHit hit;

            Physics.Raycast(transform.position + new Vector3(0, .5f, 0), direction, out hit,
              i, levelMask);



            if (hit.collider)
            {
		    if (hit.collider.tag == "Destructable")
		    { 
			    Destroy( hit.collider.gameObject);
			    Debug.Log("Hit destroyable");
			    Instantiate(destroyBlocks, transform.position + ( i * direction), destroyBlocks.transform.rotation);
			    break;
		    }
		    else
		    { 
			break;	
		    }
		    /*
                Instantiate(explosionPrefab, transform.position + (i * direction),

                  explosionPrefab.transform.rotation);
		  */

            }
            else
            {

                Instantiate(explosionPrefab, transform.position + (i * direction),

                  explosionPrefab.transform.rotation);
            }

            yield return new WaitForSeconds(.05f);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (!exploded && other.CompareTag("Explosion"))
        //if ( other.CompareTag("Explosion"))
        {
            CancelInvoke("Explode");
            Explode();
        }
       // else if ( other.ComapreTag.())


    }


}
