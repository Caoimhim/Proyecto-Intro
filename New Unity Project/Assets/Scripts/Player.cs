using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    //Amount of players
    [Range(1, 2)]
    //Setting player number
    public int iPNumber = 1;
    //inventory
    public int iBombs = 2;

    //delcare the bomb boject
    public GameObject bombPrefab;

    //characterstics
    private Rigidbody rigidBody;
    private Transform playerTransform;
    private Animator animator;

    //initializing
    void Start()
    {
       rigidBody = GetComponent<Rigidbody> ();
       playerTransform = transform;
       
        //call animator here
    }
        void Update ()
    {
        UpdateMovement();
    }
    private void UpdateMovement ()
    {
        //animation

        if ( iPNumber == 1)
        {
            UpdateP1Movement();
        }
        else
        {
            UpdateP2Movement();
        }
    }


    private void UpdateP1Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
            //Need to also call animation here
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 4f * Time.deltaTime);
        }
        if (Input.GetKeyDown (KeyCode.Space))
        {
		if (iBombs > 0)
		{ 
            		DropBomb();
	    		iBombs--;
		}
        }

    }

    private void UpdateP2Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
            //Need to also call animation here
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 4f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
		if (iBombs > 0)
		{ 
            		DropBomb();
	    		iBombs--;
		}
        }
    }

    private void DropBomb ()
    {
	    
        //Instantiate(bombPrefab, playerTransform.position, bombPrefab.transform.rotation);
        Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(playerTransform.position.x), bombPrefab.transform.position.y, Mathf.RoundToInt(playerTransform.position.z)), bombPrefab.transform.rotation);
    }

}
