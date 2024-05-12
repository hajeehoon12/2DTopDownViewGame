using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1 : MonoBehaviour
{

    public GameObject Quest_Image;
    private float diff_x;
    private float diff_y;
    public GameObject Quest_Npc;

    private bool isQuestOn = false;
    private bool isQuestAccepted = false;

    private void Awake()
    {
        Quest_Npc = this.gameObject;
    }


    private void Update()
    {
        (diff_x, diff_y)=GameManager.Instance.CheckPlayerPosition(Quest_Npc.transform.position.x, Quest_Npc.transform.position.y);
        //Debug.Log(diff_x);
        //Debug.Log(diff_y);
        if (diff_x == 0 && diff_y == 0)
        {

        }
        else if (diff_x < 4.0f && diff_y < 4.0f && !isQuestOn)
        {
            Quest_On();   
        }
        else if((diff_x >5.0f || diff_y > 5.0f) && !isQuestAccepted)
        {
            isQuestOn = false;
        }
    
    }



    public void Quest_On()
    {
        isQuestOn = true;
        Quest_Image.SetActive(true);

    
    }

    public void Quest_Off()
    {
        
        Quest_Image.SetActive(false);
        
     
    }

    public void Quest_Accept()
    {
        
        // Quest_Accept_Code
        Quest_Image.SetActive(false);
        isQuestAccepted = true;
    }



    // Start is called before the first frame update
   
}
