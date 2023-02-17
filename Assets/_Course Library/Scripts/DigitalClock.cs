using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DigitalClock : MonoBehaviour
{
    public TextMeshPro clockText;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0, 1.0f);
    }

    void UpdateTime()
    {
        clockText.text = System.DateTime.Now.ToString("HH:mm:ss");
    }
}
