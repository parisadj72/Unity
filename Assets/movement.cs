using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardforce = 200f;
    public float sidewaysforce = 500f;
    public float jumpforce = 900f;

    public Text score;

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name.Contains("Cylinder"))
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Destroy(collision.gameObject);

        }
    }


        // Start is called before the first frame update
        void Start()
    {

    }

    // Update is called once per frame
    // we use fixedupdate because we are using mess with physics
    void FixedUpdate()
    {
        //if (Input.GetKey("w"))
        //{
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, jumpforce * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-1 * sidewaysforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }

    }
}
