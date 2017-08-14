using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TestOnlyZoomRTS : MonoBehaviour
{
    public float CurrentZoom = 0;
    public float ZoomZpeed = 1;
    public float ZoomRotation = 1;
    public Vector2 zoomRange = new Vector2(-10, 100);
    public Vector2 zoomAngleRange = new Vector2(20, 70);
    private Vector3 initialPosition;
    private Vector3 initialRotation;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.eulerAngles;
    }
    void Update()
    {
        AllZoomMethods();
    }

    private void AllZoomMethods()
    {
        CurrentZoom -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 1000 * ZoomZpeed;
        CurrentZoom = Mathf.Clamp(CurrentZoom, zoomRange.x, zoomRange.y);
        transform.position = new Vector3(transform.position.x, transform.position.y - (transform.position.y - (initialPosition.y + CurrentZoom)) * 0.1f, transform.position.z);
        float x = transform.eulerAngles.x - (transform.eulerAngles.x - (initialRotation.x + CurrentZoom * ZoomRotation)) * 0.1f;
        x = Mathf.Clamp(x, zoomAngleRange.x, zoomAngleRange.y);
        transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}

