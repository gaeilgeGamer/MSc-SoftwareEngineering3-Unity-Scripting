using UnityEngine;

namespace LevelDesign
{
    public class ScaleObject : MonoBehaviour
    {
        public float pulseSpeed = 1.0f;
        public float minScale = 0.8f;
        public float maxScale = 1.2f;

        private void Update()
        {
            float scaleValue = (Mathf.Sin(Time.time * pulseSpeed) + 1) / 2; // oscillates between 0 and 1
            float newScale = Mathf.Lerp(minScale, maxScale, scaleValue);
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }
}
