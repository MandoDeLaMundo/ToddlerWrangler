using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string mLevelName;

    public void LevelStart()
    {
        SceneManager.LoadScene(mLevelName);
    }
}
