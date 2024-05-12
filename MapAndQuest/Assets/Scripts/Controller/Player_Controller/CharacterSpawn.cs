using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour // Character Spawn Controller
{
    public GameObject spawnPrefab; // empty game object
    
    public GameObject myPlayer; // to call player address




    // Start is called before the first frame update

    private void Awake()
    {
        spawnPrefab = GetComponent<GameObject>();  
    }


    void Start()
    {
        spawnPrefab = GameManager.Instance.playerChar;  // selected character gameobject
        myPlayer = Instantiate(spawnPrefab); // spawn selected prefab and make address named myPlayer
        Camera.main.GetComponent<CameraController>().CameraInitializer(myPlayer); // make camera link to player
        GameManager.Instance.curPlayer = myPlayer;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
