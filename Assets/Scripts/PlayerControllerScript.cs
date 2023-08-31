using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    private float _speed;
    private GameObject _focalPoint;
    private Rigidbody _playerBody;
    private float _verticalInput;
    private bool _isOnGround;

    public bool IsOnGround { get => _isOnGround; set => _isOnGround = value; }

    // Start is called before the first frame update
    void Start()
    {
        _speed = 10;
        _playerBody = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find("FocalPoint");
        IsOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _playerBody.AddForce(_focalPoint.transform.forward * _verticalInput * _speed);
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
        }
        
    }


}
