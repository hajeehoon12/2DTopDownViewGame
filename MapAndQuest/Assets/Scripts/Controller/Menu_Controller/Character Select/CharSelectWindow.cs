using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectWindow : MonoBehaviour
{
    public GameObject charSelect;


    public void Start()
    {
        charSelect.SetActive(false);
    }

    public void CharSelectWindowOn()
    {
        if(charSelect.activeSelf == false) charSelect.SetActive(true);
        else charSelect.SetActive(false);
    }
}
