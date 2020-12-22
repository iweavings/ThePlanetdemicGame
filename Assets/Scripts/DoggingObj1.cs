using UnityEngine;


// I have a Parent-cube in Level 2, called DoggingObj1.
//I want to create an AudioSource sound effect to go with it.

public class DoggingObj1 : MonoBehaviour
    
{
    public AudioSource effectSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter()
    {
        
        if (gameObject.tag == "Target")
        {    
          Destroy (gameObject);
        }
        
    }
}

