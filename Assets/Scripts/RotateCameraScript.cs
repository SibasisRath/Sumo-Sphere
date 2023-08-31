using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraScript : MonoBehaviour
{
    private float _rotationSpeed;
    private float _horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        _rotationSpeed = 150;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, _horizontalInput * Time.deltaTime * _rotationSpeed);
    }
}
