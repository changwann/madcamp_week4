using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "Play_button":
                SceneManager.LoadScene("PlayScene");
                break;
            case "Setting_button":
                SceneManager.LoadScene("SettingScene");
                break;
            case "Go_Button":
                SceneManager.LoadScene("GameScene");
                break;
            case "Play_Button_MP3":
                SceneManager.LoadScene("GameScene");
                break;
            case "File_Button":
                SceneManager.LoadScene("FileScene");
                break;
        }
    }

}
