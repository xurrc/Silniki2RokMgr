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
		Debug.Log("XD");

		switch (collider.tag)
		{
			case "Target_8":
			Debug.Log("8 PUNKTOW");
			Destroy(gameObject);
			break;
		}

		
	
	}

	
}





