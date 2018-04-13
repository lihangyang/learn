using UnityEngine;
using System.Collections;

public class A2 : MonoBehaviour
{

    private Transform s;
    void Start()
    {
        s = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            s.Translate(Vector3.forward * 3f, Space.World);

        }
        if (Input.GetKey(KeyCode.K))
        {
            s.Translate(Vector3.back * 3f, Space.World);

        }
        if (Input.GetKey(KeyCode.J))
        {
            s.Translate(Vector3.left * 3f, Space.World);

        }
        if (Input.GetKey(KeyCode.L))
        {
            s.Translate(Vector3.right * 3f, Space.World);

        }


    }

}
