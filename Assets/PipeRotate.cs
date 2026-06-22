using UnityEngine;

public class PipeRotate : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void Update()
    {
        float rotate = Input.GetAxisRaw("Horizontal");

        transform.Rotate(
            0f,
            rotate * rotateSpeed * Time.deltaTime,
            0f
        );
    }
}
