using UnityEngine;
using System.Collections;

public class haha : MonoBehaviour {
    public float speed = 0.01F;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
        }
    }
} 
