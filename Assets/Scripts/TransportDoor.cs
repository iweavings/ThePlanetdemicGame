using UnityEngine;

public class TransportDoor : MonoBehaviour
{
    // Transform door helps to locate the position of the player and assign
    // the time that the player hits the door, the door movement upwards + dowads
    //every time the player comes close to it from either side.

    //public Transform door;

    public Vector3 closedPosition = new Vector3(.51f, 3.63f, 0);
    public Vector3 openedPosition = new Vector3(.1f, 7, 0);

    public float openSpeed = 5;

    public bool open = false;

    // Start is not called 
   

    // Update is called once per frame
    // setting the doors position to the clossest position, using Lerp, this will return a value closer to  " a different" value. 
    // "From door position to the "opened position" and doing this in a long position of time.

    void Update()
    {
        if (open)
        {
            transform.position = Vector3.Lerp(transform.position, openedPosition, Time.deltaTime * openSpeed);
        }

        else
        {
            transform.position = Vector3.Lerp(transform.position, closedPosition, Time.deltaTime * openSpeed);
        }

    }

    // to open and cose door we use OnTrigger Enter/Exit

    private void OnTriggerEnter(Collider other) // 2 triggers can't collide to each other. so "other"
    {

        if (other.tag == "Player")
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            CloseDoor();
        }
        
    }

    

    public void CloseDoor()
    {
        open = false;

    }


    public void OpenDoor()
    {
        open = true;
    }
}
