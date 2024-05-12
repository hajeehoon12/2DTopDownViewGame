using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ParticipateController : MonoBehaviour
{
    public GameObject participate;
    public GameObject player1;
    public GameObject player2;
    public Text player1_text;
    public Text player2_text;
    


    private void Awake()
    {
        participate = GetComponent<GameObject>();
        //player1 = GetComponentInChildren<GameObject>();
        //player2 = GetComponentInChildren<GameObject>();  
    }

    private void Start()
    {
        participate = this.gameObject;
        participate.SetActive(false);
    }

    public void ActiveParticipate() // when participate button is clicked
    {
        participate.SetActive(true);

        if (GameManager.Instance.charNum)
        {
            player2.SetActive(true);
            player2_text.text = GameManager.Instance.playerName;
        }
        else
        {
            player1.SetActive(true);
            player2_text.text = GameManager.Instance.playerName;
        }
        
    }

    public void UnActiveParticipate()
    { 
        participate.SetActive(false);
    }



}
