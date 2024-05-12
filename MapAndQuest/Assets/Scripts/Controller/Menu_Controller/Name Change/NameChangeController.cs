using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeController : MonoBehaviour
{
    // Start is called before the first frame update


    //public InputNameController inputNameController;
    public GameObject input_Name_Controller;
    public GameObject participate_Controller;

    public void Awake() // when program is initialize set active false of controller
    {
        input_Name_Controller.SetActive(false);
    }


    public void NameChange() // when namechange button clicked
    {
        if (input_Name_Controller.activeSelf == false) input_Name_Controller.SetActive(true); // when window was off
        else input_Name_Controller.SetActive(false);
    
        participate_Controller.SetActive(false);

        //input_Name_Controller.GetComponent<InputNameController>().InputName();
        //inputNameController.InputName(); 
    }
}
