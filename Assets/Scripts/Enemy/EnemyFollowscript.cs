using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowscript : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _playerPosition;
    private Vector3 _distance;
    private Rigidbody _enemyRigidBody;
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 5;
        _enemyRigidBody = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (_player !=null)
        {
            _playerPosition = _player.transform.position;
            _distance = _playerPosition - transform.position;
            _enemyRigidBody.AddForce(_distance.normalized * _speed);
        }
       
    }
}
