using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharSelect : MonoBehaviour // Button on Character Select Window
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
