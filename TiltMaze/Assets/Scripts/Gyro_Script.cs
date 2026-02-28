using UnityEngine;

public class Gyro_Script : MonoBehaviour
{
    //VERSION #1 (VIDEO-BASED):
    /*
    Vector3 rot;
    void Start()
    {
        //to enable gyroscope on Android
        Input.gyro.enabled = true;
    }

    void Update()
    {
        rot.x = -Input.gyro.rotationRateUnbiased.x;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);
        //transform.rotation = Input.gyro.attitude;
        transform.Rotate(rot);
    }
    */

    //VERSION #2 (MODIFIED FOR X & Y VALUES):
    /*
    Vector3 xRotation, yRotation;
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        xRotation.x = -Input.gyro.rotationRateUnbiased.x;
        yRotation.y = Input.gyro.rotationRateUnbiased.y;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);
        transform.Rotate(xRotation);
        transform.Rotate(yRotation);
    }
    */
    

    //VERSION #3 (MODIFIED W/ SPECIFIC):
    /* 
    public float xRotation, yRotation;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        xRotation = -Input.gyro.rotationRateUnbiased.x;
        yRotation = Input.gyro.rotationRateUnbiased.y;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);
        transform.Rotate(xRotation, yRotation, 0.0f, Space.Self);
    }
    */

    //VERSION #4 (MODIFIED W/ LIMITATIONS):
    
    public float xRotation = 0;
    public float yRotation = 0;
    public float clampAngle = 20;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        xRotation = -Input.gyro.rotationRateUnbiased.x;
        yRotation = Input.gyro.rotationRateUnbiased.y;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);
        transform.Rotate(xRotation, yRotation, 0.0f, Space.Self);
    }
    
}
