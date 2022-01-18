using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{	
	bool gameHasEnded= false;


	public void EndGame()
	{
		if (gameHasEnded == false)
		{	
			gameHasEnded = true;
			Debug.Log("SIEMANKO");
			Restart();
		}
	}

	void Restart()
	{
		FindObjectOfType<FirstPersonController>().CursorUnlock();
		
		SceneManager.LoadScene("MenuLoose");
	}
}
