using UnityEngine;
using System.Collections;

public class A1 : MonoBehaviour
{

    private Transform s;
    void Start()
    {
        s = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            s.Translate(Vector3.forward * 0.3f, Space.World);

        }
        if (Input.GetKey(KeyCode.S))
        {
            s.Translate(Vector3.back * 0.3f, Space.World);

        }
        if (Input.GetKey(KeyCode.A))
        {
            s.Translate(Vector3.left * 0.3f, Space.World);

        }
        if (Input.GetKey(KeyCode.D))
        {
            s.Translate(Vector3.right * 0.3f, Space.World);

        }


    }

}