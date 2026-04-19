using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _driveSpeed = 20f;
    private float _turnSpeed = 45f;
    private float _horizontalInput;
    private float _forwardInput;
    
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Moves the car forward based on the vertical input
        transform.Translate(Vector3.forward * (Time.deltaTime * _driveSpeed * _forwardInput)); 
        
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * (Time.deltaTime * _turnSpeed * _horizontalInput));

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
