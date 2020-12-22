using UnityEngine;

public class MovingShuttle : MonoBehaviour
{

    public float speed = 7; // how fast our sphere is going to run.


    private Rigidbody body;
    

    private void Start()


    {
        body = GetComponent<Rigidbody>();

    }



    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // for 'a' and 'd' keys
        float moveVertical = Input.GetAxis("Vertical"); // for 'w' and 's' keys


        // for Axis , "a' and 'd' keys for horiz., and Asis 'w' amd 's' for Vertical 
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);  

        body.AddForce(movement * speed);


    }

    
}