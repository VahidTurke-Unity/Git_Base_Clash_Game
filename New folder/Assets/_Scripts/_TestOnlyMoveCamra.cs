using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class _TestOnlyMoveCamra : MonoBehaviour
{
    // Use this for initialization
    public Vector3 centerPt;
    public float radius;
    public float _X_Min, _X_Max, _Y_Min, _Y_Max, _Z_Min, _Z_Max;
    void Update()
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(transform.position.x, _X_Min, _X_Max);
        clampedPosition.y = Mathf.Clamp(transform.position.y, _Y_Min, _Y_Max);
        clampedPosition.z = Mathf.Clamp(transform.position.z, _Z_Min, _Z_Max);
        transform.position = clampedPosition;
        MoveForDrag();
    }
    void MoveForDrag()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 movement = new Vector3(-Input.GetAxis("Mouse X"), 0, -Input.GetAxis("Mouse Y"));
            Vector3 newPos = transform.position + movement;
            centerPt = transform.position;
            Vector3 offset = newPos - centerPt;
            transform.position = centerPt + Vector3.ClampMagnitude(offset, radius);
        }
    }


}
