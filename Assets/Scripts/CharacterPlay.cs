using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlay : MonoBehaviour
{


    // Calling Rigidbody evokes the physics and gravity to the object
    private Rigidbody body;

    // Callind moveSpeed,will add force to one direction, at a time that I might decide
    // @ Unity interface; or by multyplying to a specific value under private vid FixedUpdate.
    // So we create this varialbe for it.
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

    //Remember that FixedUpdate realtes to "all things Physics"
    //the force is added forward or 'right" in Axis. The speed can be adjusted @ Unity Interface,
    // and the Time will be fixed to: the movement/speed, the way you hold one key or two togethere.

    private void FixedUpdate()
    {

        body.AddForce(0, 0, 1000 * Time.deltaTime);

        // Time.fixedDeltaTime, allows you to have some control using your keys, 
        //so that the object might not fly out of the scene. And keeps Pysics consistant.

        body.AddForce(transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime);
        body.AddForce(transform.right * Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided!");

    }
}
