using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    private Rigidbody body;
    private int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        body.AddForce(transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime);
        body.AddForce(transform.right * Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter()
    {
        Debug.Log("Collider!");
    }
}


