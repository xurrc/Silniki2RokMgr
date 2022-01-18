using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target_destruction : MonoBehaviour
{

	
	public bool didHit;

	void OnTriggerEnter(Collider collider)
	{
		if (didHit) return;
		didHit = true;
		Destroy(transform.parent.gameObject);
	}
}





