using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
