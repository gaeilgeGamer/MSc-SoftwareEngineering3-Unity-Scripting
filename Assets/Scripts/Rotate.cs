// RotateObject.cs
using UnityEngine;

namespace LevelDesign
{
    public class RotateObject : MonoBehaviour
    {
        public float rotationSpeed = 30.0f;

        // Update is called once per frame
        void Update()
        {
            Rotate();
        }

        void Rotate()
        {
            // Rotate around its local Y axis
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}

