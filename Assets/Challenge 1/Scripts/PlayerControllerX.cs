using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        public float speed = 15;
        public float rotationSpeed = 100;
        private float _verticalInput;
    
        // Update is called once per frame
        void FixedUpdate()
        {
            // get the user's vertical input
            _verticalInput = Input.GetAxis("Vertical");

            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * _verticalInput));
        }
    }
}
