using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_destroy : MonoBehaviour
{
	
	void OnTriggerEnter(Collider collider)
	{
		Destroy(gameObject);
	}
}
