using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneButtonLogic : MonoBehaviour {


    bool nameEntered = false;
    bool ageEntered = false;
    
    public void NameEntered()
    {
        nameEntered = true;
        if (ageEntered)
        {
            GetComponent<Button>().interactable=true;
        }
    }
    
    public void AgeEntered()
    {
        ageEntered = true;
        if (nameEntered)
        {
            GetComponent<Button>().interactable=true;
        }
    }
}
