using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Score : MonoBehaviour
{

	
	public bool didHit;

	void OnTriggerEnter(Collider collider)
	{
		if (didHit) return;
		didHit = true;
		Destroy(gameObject);
	}
}





