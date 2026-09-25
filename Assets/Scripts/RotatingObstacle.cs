using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObstacle : MonoBehaviour
{
    public bool isActive = true;
    public float rotationSpeed = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Rotating Obstacle is running");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftAltKey.wasPressedThisFrame) 
        {
            isActive = !isActive;
        }
        if (isActive)
        {
            transform.Rotate(
                0f,
                rotationSpeed * Time.deltaTime,
                0f);
        }
    }
}
