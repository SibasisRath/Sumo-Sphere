using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPower : MonoBehaviour
{
    private Vector3 scaleChange, positionChange;

    void Awake()
    {
        transform.position = new Vector3(0, 0, 0);

        scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);
        positionChange = new Vector3(0.0f, -0.05f, 0.0f);
    }
    private void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;

        if (transform.localScale.y < 2.39f || transform.localScale.y > 10f)
        {
            scaleChange = -scaleChange;
            positionChange = -positionChange;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.gameObject.transform.position - transform.position) * 10, ForceMode.Impulse);
            Debug.Log("Enemy + Green");
            StartCoroutine(TimeLast());
        }
    }
    IEnumerator TimeLast()
    {
        yield return new WaitForSeconds(5);
        YourPower greenPower = GameObject.Find("Player").GetComponent<YourPower>();
        //greenPower.GetComponent<SfxScript>().PlayPowerDownSound();
        greenPower.HasPowerUp = false;
        Debug.Log("Power down");
    }
}
