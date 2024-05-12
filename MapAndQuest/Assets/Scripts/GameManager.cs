using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Sprite myChar;
    public Sprite penguin;
    public Sprite cat;
    public GameObject playerChar;
    public GameObject playerCat;
    public GameObject playerPenguin;
    public string playerName = "Name";
    public bool charNum = true; // true = cat, false = penguin

    public GameObject curPlayer;

    private void Awake()
    {
        myChar = GetComponent<Sprite>();
        //playerChar = GetComponent<GameObject>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void ChoosePenguin()
    {
        myChar = penguin;
        playerChar = playerPenguin;
        GameStart();
        charNum = false; // when penguin , true
    }

    public void ChooseCat()
    { 
        myChar = cat;
        playerChar = playerCat;
        GameStart();
        charNum = true;
    }

    private void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }


    public (float x, float y) CheckPlayerPosition(float opponent_x,float opponent_y)
    {
        
        if (curPlayer != null) // code guard
            return (Mathf.Abs(curPlayer.transform.position.x- opponent_x), Mathf.Abs(curPlayer.transform.position.y- opponent_y) );
        else
            return (0, 0);
    }

}
