using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Cycle Settings")]
    [Tooltip("How long a full day lasts in seconds")]
    public float dayLength = 120f;

    [Tooltip("Axis to rotate around (usually X for sun movement)")]
    public Vector3 rotationAxis = Vector3.right;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees over the full day length
        rotationSpeed = 360f / dayLength;
    }

    void Update()
    {
        // Rotate the light over time
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}