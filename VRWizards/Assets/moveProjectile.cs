using UnityEngine;
using System.Collections;
using Leap;

public class moveProjectile : MonoBehaviour {

	private Rigidbody rig;
	public float force = 100000;
	private Quaternion rot;
	public HandModel hand;
	public Transform target;

	// Use this for initialization
	void Start () {

		target = GameObject.Find ("Target").transform;

	//	Quaternion lookAt = Quaternion.LookRotation(hand.GetPalmRotation() - transform.position);
		//rot = Quaternion.FromToRotation(Vector3.forward, ;
		rig = GetComponent<Rigidbody> ();
		//rig.AddForce (hand.GetPalmRotation().eulerAngles * force);
		rig.AddForce ((transform.position - target.transform.position) * force);
		//rig.AddForce ((hand.GetPalmDirection()) * force);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

		//transform.position = Vector3.MoveTowards(transform.position, target.position, force);
	}
}
