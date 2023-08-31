using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePower : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.gameObject.transform.position - transform.position) * 20, ForceMode.Impulse);
            Debug.Log("Enemy + Blue");
            StartCoroutine(TimeLast());
        }
    }
    IEnumerator TimeLast()
    {
        yield return new WaitForSeconds(10);
        YourPower bluePower = GameObject.Find("Player").GetComponent<YourPower>();
        //bluePower.GetComponent<SfxScript>().PlayPowerDownSound();
        bluePower.HasPowerUp = false;
        Debug.Log("Power down");
    } 
}
