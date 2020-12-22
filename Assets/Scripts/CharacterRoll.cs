using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRoll : MonoBehaviour
{
    // to give movement to Rigidbody add rb
 
    public Rigidbody body;
    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
       body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Fixed update for all things physics. helps the object to move freely "Globally' or "locally"
    public void FixedUpdate()
    {
        

        // Look for if I am pressing the Up arrow.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime);
            body.AddForce(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
