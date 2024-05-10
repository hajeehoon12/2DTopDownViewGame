using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    
    public GameObject myPlayer;


    // Start is called before the first frame update

    private void Awake()
    {
        spawnPrefab = GetComponent<GameObject>();  
        
    }


    void Start()
    {
        spawnPrefab = GameManager.Instance.playerChar;
        myPlayer = Instantiate(spawnPrefab);
        Camera.main.GetComponent<CameraController>().CameraInitializer(myPlayer);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
