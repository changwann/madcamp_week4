using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneLoader : MonoBehaviour
{
    public string firstSceneName = "Main Menu"; // 첫 화면으로 설정할 씬의 이름

    void Start()
    {
        LoadFirstScene();
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(firstSceneName);
    }
}