using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ScoreTest : MonoBehaviour
{
    public TextMeshProUGUI stage1;
    public TextMeshProUGUI stage2;

    void Start()
    {
        stage1.text = "Stage 1 : " + HighScore.Load(1).ToString();
        stage2.text = "Stage 1 : " + HighScore.Load(1).ToString();
    }

}
