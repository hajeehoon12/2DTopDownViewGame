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

    public void ActiveParticipate()
    {
        participate.SetActive(true);

        if (GameManager.Instance.charNum)
        {
            player2.SetActive(true);
        }
        else
        {
            player1.SetActive(true);
        }
    }

    public void UnActiveParticipate()
    { 
        participate.SetActive(false);
    }



}