using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool mIsGameActive;
    public GameObject mPlayer;
    public string mGameOverText;
    public string mGameContinue;
    public static GameManager instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
        mIsGameActive = true;
    }
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && mIsGameActive == true)
            GameOver();
        if (Input.GetKey(KeyCode.L) && mIsGameActive == false)
            StartGame();
    }

    void StartGame()
    {
        mPlayer.transform.position = Vector3.zero;
        mPlayer.transform.rotation = Quaternion.Euler(0, 0, 0); 
        SceneManager.LoadScene(mGameContinue);
        mIsGameActive = true;
    }

    void GameOver()
    {
        SceneManager.LoadScene(mGameOverText);
        mIsGameActive = false;
    }
}
