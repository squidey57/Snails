using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExplorerMechanics : MonoBehaviour
{


	private int _score;
	public int _health = 3;

	
	public void LoadScene0()
	{
		SceneManager.LoadScene("winning");
	}

	public void LoadScene1()
	{
		SceneManager.LoadScene("unlucky");
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
			LoadScene0();
		}

		if (col.CompareTag("Camo"))
		{
			_health = _health - 1;
			Debug.Log(_health);
		}

		if (col.CompareTag("Camo") & _health == 0)
		{
			Destroy(gameObject);
			LoadScene1();
		}

		if (col.CompareTag("HoleTrap"))
		{
			Destroy(gameObject);
			Destroy(col.gameObject);
			LoadScene1();
		}

		if (col.CompareTag("FireTrap"))
		{
			_health = _health - 1;
			Debug.Log(_health);
		}


		if (col.CompareTag("Arrow"))
		{
			_health = _health - 1;
			Debug.Log(_health);
		}
		
	}
	
}
