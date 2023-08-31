using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourPower : MonoBehaviour
{
    private bool _hasPowerUp;
    [SerializeField] GameObject _powerUpIndicatorGreen;
    [SerializeField] GameObject _powerUpIndicatorBlue;


    // Start is called before the first frame update
    void Start()
    {
        _hasPowerUp = false;

       
       
       
        _powerUpIndicatorGreen.SetActive(false);
        _powerUpIndicatorBlue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        _powerUpIndicatorGreen.transform.position = transform.position;
        _powerUpIndicatorBlue.transform.position = transform.position;
       

        if (HasPowerUp == false)
        {
            
            
            _powerUpIndicatorBlue.SetActive(false);
           
            _powerUpIndicatorGreen.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!HasPowerUp)
        {
            if (other.CompareTag("PowerUpGreen"))
            {
                _hasPowerUp = true;
                Debug.Log("Green Power up");
                _powerUpIndicatorGreen.SetActive(true);
               
            }
            else if (other.CompareTag("PowerUpBlue"))
            {
                _hasPowerUp = true;
               
                Debug.Log("Blue Power up");
                _powerUpIndicatorBlue.SetActive(true);
               
            }
           
            
            Destroy(other.gameObject);
        }
        else
        {
            return;
        }
    }

    public bool HasPowerUp
    {
        get { return _hasPowerUp; }
        set { _hasPowerUp = value; }
    }
}
