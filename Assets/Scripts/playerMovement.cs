using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -4.5f, 4.5f));
        transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);

        }
    }
}
