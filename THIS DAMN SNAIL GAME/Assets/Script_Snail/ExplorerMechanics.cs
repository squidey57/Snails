using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExplorerMechanics : MonoBehaviour
{


	private int _score;
	private int _health = 3;
	
	public void LoadScene()
	{
		SceneManager.LoadScene("winning");
	}
	
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Switch"))
		{
			_score++;
			Destroy(col.gameObject);
			Debug.Log(_score);
		}

		if (_score == 3 & col.CompareTag("Trophy") )
		{
			Destroy(col.gameObject);
			Debug.Log("WINNER!");
			LoadScene();
		}
	}
	
}
