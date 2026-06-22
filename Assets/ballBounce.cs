using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ballBounce : MonoBehaviour
{
    Rigidbody rb;
    public Text scoreText;
    float score = 0;

    public float bounceHeight = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        rb.linearVelocity = new Vector3(
            0f,
            bounceHeight,
            0f );
        if (collision.gameObject.CompareTag("pink"))
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.CompareTag("final"))
        {
            SceneManager.LoadScene("GameComplete");
        }
        if (collision.gameObject.CompareTag("blue"))
        {
            score += 5;
            scoreText.text = score.ToString();

            collision.gameObject.tag = "Untagged";
        }
    }
    
}