using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    
    // Start is called before the first frame update
   

    
    public void StartG()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void DifficultyM()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void SettingsM()
    {
        SceneManager.LoadScene("Settings");
    }
    public void QuitGameM()
    {
        SceneManager.LoadScene("QuitGame");
        
    }
    public void EasyG()
    {
        SceneManager.LoadScene("Easy");
    }
    public void NormalG()
    {
        SceneManager.LoadScene("Hard");
    }
    public void HardG()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void VeryHardG()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void BackG()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void YesG()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void NoG()
    {
        SceneManager.LoadScene("End");
    }
   
    public void EasyyG()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void Hard_G()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void HomeG()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

