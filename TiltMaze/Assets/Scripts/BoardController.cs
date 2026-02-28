using UnityEngine;

public class BoardController : MonoBehaviour
{
    
    public float rotationSpeed;
    public float clampAngle;

    private float currentRotX = 0f;
    private float currentRotY = 0f;
    private float currentRotZ = 0f;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation = -Input.gyro.rotationRateUnbiased.x;
        //float yRotation = Input.gyro.rotationRateUnbiased.y;
        float zRotation = Input.gyro.rotationRateUnbiased.z;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);

        //To calculate rotation amt for X & Y Axes
        currentRotX += xRotation * rotationSpeed * Time.deltaTime;
        //currentRotY += yRotation * rotationSpeed * Time.deltaTime;
        currentRotZ += zRotation * rotationSpeed * Time.deltaTime;

        //To clamp X & Y rotations to prevent excessive tilting
        currentRotX = Mathf.Clamp(currentRotX, -clampAngle, clampAngle);
        //currentRotY = Mathf.Clamp(currentRotY, -clampAngle, clampAngle);
        currentRotZ = Mathf.Clamp(currentRotZ, -clampAngle, clampAngle);

        //To apply rotation to platform
        transform.localRotation = Quaternion.Euler((currentRotX-89.9f), 0.0f, currentRotZ);
    }
    

    /*
    public float rotationSpeed;
    public float clampAngle;

    private float currentRotX = 0f;
    private float currentRotZ = 0f;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation = -Input.gyro.rotationRateUnbiased.x;
        float zRotation = Input.gyro.rotationRateUnbiased.z;
        Debug.Log("Input Gyro Attitude: " + Input.gyro.attitude);

        //To calculate rotation amt for X & Y Axes
        currentRotX += xRotation * rotationSpeed * Time.deltaTime;
        currentRotZ += zRotation * rotationSpeed * Time.deltaTime;
        Debug.Log("Rotation Amount X: " + currentRotX);

        //To clamp X & Y rotations to prevent excessive tilting
        currentRotX = Mathf.Clamp(currentRotX, -clampAngle, clampAngle);
        currentRotZ = Mathf.Clamp(currentRotZ, -clampAngle, clampAngle);
        Debug.Log("Clamped Rotation Amount X: " + currentRotX);

        //To apply rotation to platform
        transform.rotation = Quaternion.Euler((currentRotX-89.9f), 0f, currentRotZ);
    }
    */
}
