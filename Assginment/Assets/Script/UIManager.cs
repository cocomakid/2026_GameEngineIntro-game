using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void GameStartButtonAction()
    {
        SceneManager.LoadScene("Level_1");
    }
}
