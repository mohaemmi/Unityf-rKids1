using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KugelKontrolle : MonoBehaviour
{

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
          body.AddForce (Vector3.left * 5);
        if (Input.GetKey(KeyCode.RightArrow))
          body.AddForce (Vector3.right * 5);
        if (Input.GetKey(KeyCode.UpArrow))
          body.AddForce (Vector3.up * 10);
    }
}
