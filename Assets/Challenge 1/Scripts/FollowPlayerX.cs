using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        public GameObject plane;
        private Vector3 _offset;

        // Start is called before the first frame update
        void Start()
        {
            _offset = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = plane.transform.position + _offset;
        }
    }
}
