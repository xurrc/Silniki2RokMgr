using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_destroy : MonoBehaviour
{
	public bool didHit;

	void OnTriggerEnter(Collider collider)
	{
		if (didHit) return;
		didHit = true;
		Destroy(gameObject);
	}
}
