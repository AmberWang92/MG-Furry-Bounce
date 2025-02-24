using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Runtime.CompilerServices;

public class Gravity : MonoBehaviour
{
    private Accelerometer accelerometer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float grav = 9.8f;
    [SerializeField] private TMP_Text debugText;

    void Start()
    {
        accelerometer = InputSystem.GetDevice<Accelerometer>();


        if (accelerometer != null)
        {

            InputSystem.EnableDevice(Accelerometer.current);
        }
    }
    void Update()
    {
        if (accelerometer != null)
        {
            Vector2 deviceOrientation = accelerometer.acceleration.ReadValue();
            Physics2D.gravity = grav * deviceOrientation;
            debugText.text = ("Gravity: " + grav * deviceOrientation);

        }
    }
}
