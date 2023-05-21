using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    public float pitch = 2f;

    public float yawspeed = 100f;
    private float yawinput = 0f;

    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 10f;
    private float currentZoom = 10f;
    // Start is called before the first frame update

    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        yawinput -= Input.GetAxis("Horizontal") * yawspeed * Time.deltaTime;
    }
    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
        transform.RotateAround(target.position, Vector3.up, yawinput);
    }

}
