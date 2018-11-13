using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ExplorerController: MonoBehaviour
{
    private Rigidbody2D _rbody;
    private float _hAxis;
    private float _vAxis;
    private float _rAxis;
    private float _sExplorer = 500f;
    private float _rExplorer = 200f;
   
    

    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        _hAxis = Input.GetAxis("Horizontal1");
        _vAxis = Input.GetAxis("Vertical1");
        _rAxis = Input.GetAxis("Rotate1");
        _rbody.velocity = new Vector2(_hAxis * Time.fixedDeltaTime * _sExplorer,
            _vAxis * Time.fixedDeltaTime * _sExplorer);
        _rbody.MoveRotation(_rbody.rotation + _rExplorer*_rAxis* Time.fixedDeltaTime);

    }

}
