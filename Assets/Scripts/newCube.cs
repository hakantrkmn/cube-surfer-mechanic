using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCube : MonoBehaviour
{

    public GameObject collectablesCube;

    public GameObject sa;
    public Collider[] boxes;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject==transform.parent.GetChild(transform.parent.childCount-1).gameObject)
        {
            if (collision.transform.tag == "CC")
            {
                sa = collision.gameObject;
                float cubeCount = collision.gameObject.transform.childCount + 1;
                Destroy(collision.gameObject);
                for (int i = 1; i <= cubeCount; i++)
                {
                    transform.parent.transform.position = new Vector3(transform.parent.transform.position.x, transform.parent.transform.position.y + 1.1f, transform.parent.transform.position.z);
                    var newCube = Instantiate(collectablesCube, new Vector3(transform.position.x, transform.position.y - i+0.1f, transform.position.z), Quaternion.identity);
                    newCube.transform.parent = gameObject.transform.parent;
                }
            }
            
        }
        if (collision.transform.tag == "barrier")
        {
            gameObject.transform.parent = null;
        }

    }




}
