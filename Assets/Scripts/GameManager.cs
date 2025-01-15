using UnityEngine;
using UnityEngine.SceneManagement;      // to show different scenes

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won!");
        Invoke("LoadLevel1", 2f);  // Replace "LoadLevel2" with whatever method name you choose
    }

    private void LoadLevel1()  
        // Name this method to match what you used in Invoke
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("\nGame Over");
            Invoke("Restart", 1f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
