using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour // Player Name Controller
{
    public Transform player_ui;
    public GameObject player;
    Vector3 targetPos;

    void Start()
    {
        player_ui = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = player.transform.position + new Vector3(0, 0.8f, 0);
        player_ui.transform.position = Vector3.Lerp(player_ui.transform.position, targetPos, 0.2f);
    }
}
