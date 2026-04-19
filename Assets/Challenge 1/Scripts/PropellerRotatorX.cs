using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PropellerRotatorX : MonoBehaviour
    {
        private readonly float _rotationSpeed = 2500f; // Real life RPM

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0f, 0f, _rotationSpeed * Time.deltaTime);
        }
    }
}
