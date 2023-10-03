using UnityEngine;

namespace LevelDesign
{
    public class MoveObject : MonoBehaviour
    {
        public Transform pointATransform;
        public Transform pointBTransform;
        public float speed = 1.0f;

        private Vector3 pointA;
        private Vector3 pointB;
        private float journeyLength;
        private float startTime;

        private void Start()
        {
            // Check if the transforms are set in the inspector
            if (pointATransform && pointBTransform)
            {
                pointA = pointATransform.position;
                pointB = pointBTransform.position;

                startTime = Time.time;
                journeyLength = Vector3.Distance(pointA, pointB);
            }
            else
            {
                Debug.LogWarning("Point Transforms are not set! Movement will not occur.");
            }
        }

        private void Update()
        {
            if (pointATransform && pointBTransform)
            {
                float distCovered = (Time.time - startTime) * speed;
                float fractionOfJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(fractionOfJourney, 1));
            }
        }
    }
}


