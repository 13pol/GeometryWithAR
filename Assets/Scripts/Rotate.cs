using UnityEngine;

public class Rotate : MonoBehaviour
{

    float RotationSpeed = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
            float x = TouchPosition.x * Mathf.Deg2Rad * RotationSpeed;
            float y = TouchPosition.y * Mathf.Deg2Rad * RotationSpeed;

            transform.RotateAround(Vector3.zero, Vector3.up, -x);
            transform.RotateAround(Vector3.zero, Vector3.right, y);
        }
    }
}
