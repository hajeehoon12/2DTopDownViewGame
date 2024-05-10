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
        SceneManager.LoadScene("MainScene");
        
        
    }

    public void ChooseCat()
    { 
        myChar = cat;
        playerChar = playerCat;
        SceneManager.LoadScene("MainScene");
        
    }

    
}
