using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    public Camera mainCam;
    public float zoomAmount = 2.0f;
    public float zoomSpeed = 0.1f;
    private bool isZooming = false;

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == gameObject)
            {
                isZooming = true;
            }
            else
            {
                isZooming = false;
            }
        }

        if (isZooming)
        {
            mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, mainCam.fieldOfView / zoomAmount, zoomSpeed);
        }
        else
        {
            mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, 60, zoomSpeed);
        }
    }
}