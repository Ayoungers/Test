using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistController : MonoBehaviour {

    private Vector3 mousePosition;
    private Vector2 mouseVector;

    private GameObject hitObject;
    private Rigidbody2D hitRb;
    public float moveSpeed = 0.1f;
    public float maxSpeed = 1f;

	//// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.GetComponent<Rigidbody2D>().velocity = (mousePosition - transform.position).normalized * moveSpeed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mouseVector = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        hitObject = collision.gameObject;
        hitRb = gameObject.GetComponent<Rigidbody2D>();
        hitRb.AddForce(mouseVector);
    }
}
