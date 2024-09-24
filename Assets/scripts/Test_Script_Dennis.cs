using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Script_Dennis : MonoBehaviour
{

    public Rigidbody rb;            // Referenz auf den Rigidbody des Charakters, notwendig für physikalische Berechnungen
    
    
    public float speed = 5f;        // Geschwindigkeit des Charakters

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //
        // Charakter Movement with Rigidbody
        //
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + (new Vector3(x, 0, z) * speed * Time.deltaTime));

    }
}
