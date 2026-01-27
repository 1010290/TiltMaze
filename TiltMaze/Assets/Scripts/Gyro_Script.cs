using UnityEngine;

public class Gyro_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //to enable gyroscope on Android
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);
        transform.rotation = Input.gyro.attitude;
    }
}
