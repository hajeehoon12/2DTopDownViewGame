using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharSelect : MonoBehaviour
{
   

    public void SelectPenguin()
    {
        GameManager.Instance.ChoosePenguin();
        
    }

    public void SelectCat()
    {
        GameManager.Instance.ChooseCat();
       
    }



}
