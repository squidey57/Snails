using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerController: MonoBehaviour
{
    private Rigidbody2D _rbody;
    private float _hAxis;
    private float _vAxis;
    private float _sExplorer = 500f;

    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _hAxis = Input.GetAxis("Horizontal1");
        _vAxis = Input.GetAxis("Vertical1");
        _rbody.velocity = new Vector2(_hAxis * Time.fixedDeltaTime * _sExplorer,
            _vAxis * Time.fixedDeltaTime * _sExplorer);
    }

}
