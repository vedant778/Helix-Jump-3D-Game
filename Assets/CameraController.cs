using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform ball;
    float distance = -8.9f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position - new Vector3(0, distance, 0);
    }
}
