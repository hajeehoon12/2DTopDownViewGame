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
        charSelect.SetActive(true);
    }
}
