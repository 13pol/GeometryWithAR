using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangeToEnviroments()
    {
        SceneManager.LoadScene("Enviroments");
    }

    public void ChangeToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ChangeToFridge()
    {
        SceneManager.LoadScene("Fridge");
    }
    public void ChangeToGameDesk()
    {
        SceneManager.LoadScene("GameDesk");
    }
    public void ChangeToShelve()
    {
        SceneManager.LoadScene("Shelve");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
