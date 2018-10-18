using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal") > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(moveSpeed, 0));
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-moveSpeed, 0));
        }
	}
}
