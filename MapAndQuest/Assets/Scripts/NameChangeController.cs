using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeController : MonoBehaviour
{
    // Start is called before the first frame update


    //public InputNameController inputNameController;
    public GameObject input_Name_Controller;

    public void Awake()
    {
        input_Name_Controller.SetActive(false);
    }


    public void NameChange()
    {
        input_Name_Controller.SetActive(true);
        //input_Name_Controller.GetComponent<InputNameController>().InputName();
        //inputNameController.InputName();
        
    }
}
