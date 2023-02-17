using UnityEngine;

public class LightsaberScript : MonoBehaviour
{
    public GameObject Laser;
    private bool isTriggerPressed;

    private void Update()
    {
        isTriggerPressed = Input.GetAxis("Trigger") > 0;
        GetComponent<BoxCollider>().enabled = isTriggerPressed;
        Laser.transform.position = transform.position;
        Laser.transform.rotation = transform.rotation;
        Laser.gameObject.SetActive(isTriggerPressed);
    }
}
