using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TechController: MonoBehaviour
{
	private Rigidbody2D _rbody;
	private float _hAxis;
	private float _vAxis;
	private float _vTurn;
	private float _hTurn;
	private float _speed = 250f;
	private float _rspeed = 200f;
	private Vector2 _turndir;
	private float _turnA;
	private Quaternion _rot;
    
    
   
    

	void Start()
	{
		_rbody = GetComponent<Rigidbody2D>();
	}

   
	void FixedUpdate()
	{
		_hAxis = Input.GetAxis("Horizontal2");
		_vAxis = Input.GetAxis("Vertical2");
		_hTurn = Input.GetAxis("TurnH2");
		_vTurn = Input.GetAxis("TurnV2");
		_rbody.velocity = new Vector2(_hAxis * Time.fixedDeltaTime * _speed,
			_vAxis * Time.fixedDeltaTime * _speed);
		_turndir = new Vector2(_hTurn,_vTurn);
		_turnA = Mathf.Atan2(_hTurn, _vTurn) * Mathf.Rad2Deg;

		if (_vTurn != 0 && _hTurn != 0)
		{
			_rot = Quaternion.AngleAxis(_turnA, Vector3.forward);
			_rbody.transform.rotation = Quaternion.Slerp(_rbody.transform.rotation, _rot, _rspeed*Time.fixedDeltaTime);
		}


	}

}
