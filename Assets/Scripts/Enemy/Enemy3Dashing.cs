using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Dashing : MonoBehaviour
{
    private new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        InvokeRepeating("Dashing", Random.Range(2f,5f), Random.Range(3f,6f));        
    }
    void Dashing()
    {
        rigidbody.AddForce(Vector3.forward * Time.deltaTime * 5,ForceMode.Impulse);
        Debug.Log("Dashing");
    }
}
