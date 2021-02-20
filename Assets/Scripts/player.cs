using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject collectablesCube;
    public List<GameObject> createdCubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        //Use the same vars you use to draw your Overlap SPhere to draw your Wire Sphere.
        Gizmos.DrawWireSphere(transform.position, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject == transform.parent.GetChild(transform.parent.childCount - 1).gameObject)
        { 
            if (collision.transform.tag == "CC")
            {
                Destroy(collision.gameObject);
                transform.position = new Vector3(transform.position.x, transform.position.y + 1.1f, transform.position.z);
                var newCube = Instantiate(collectablesCube, new Vector3(transform.position.x, transform.position.y - 1.1f, transform.position.z), Quaternion.identity);
                newCube.transform.parent = gameObject.transform.parent;
            }
            }
        if (collision.transform.tag == "barrier")
        {
            Time.timeScale = 0.0f;
        }
    }
}
