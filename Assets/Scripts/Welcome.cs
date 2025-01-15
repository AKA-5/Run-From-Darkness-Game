using UnityEngine;
using UnityEngine.SceneManagement;
public class Welcome : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Welcome to the game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
