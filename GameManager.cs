using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject[] cubes;
	

	public void Reset()
	{
		Scene scene = SceneManager.GetActiveScene(); 
		SceneManager.LoadScene(scene.name);
	}

	public void EndGame()
	{
		Application.Quit();
	}
}
