using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNameController : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName_Input = null;
    public GameObject playerSelect_Win;

    private void Awake()
    {
        playerName_Input = playerNameInput.GetComponent<InputField>().text;
       
    }
    private void Update() // when name is entered and get submit got to inputName
    {
        //Ű����
        if (playerName_Input.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    //���콺
    public void InputName() // Change the name of the character text
    {
        playerName_Input = playerNameInput.text;
        GameManager.Instance.playerName = playerName_Input;
        gameObject.SetActive(false);
        if (playerSelect_Win != null)
        { 
            playerSelect_Win.SetActive(true);
        }
    }
}
