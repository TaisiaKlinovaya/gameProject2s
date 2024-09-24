using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float impulse = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tor")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wand")
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * impulse);
        }
    }
}
