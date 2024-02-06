using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenMenu : MonoBehaviour
{
    public GameObject menuPannel;
    public GameObject PauseButton;
    public GameObject exitButton;
    public GameObject claire;
    public GameObject thumbStickLeft;

    public GameObject pointAndClickCheck;
    public GameObject thirdPersonCheck;
    public GameObject thumbStickLeftCheck;
    
    public GameObject checkButtonPointAndClick;
    public GameObject checkButtonThirdPerson;
    public GameObject checkButtonThumbStickLeft;


    public void ActivateMenu()
    {
        menuPannel.SetActive(true);
        PauseButton.SetActive(false);
        exitButton.SetActive(true);
        claire.SetActive(false);
    }

    public void DeactivateMenu()
    {
        menuPannel.SetActive(false);
        PauseButton.SetActive(true);
        exitButton.SetActive(false);
        claire.SetActive(true);
    }

    public void ActivatePointAndClick()
    {
        gameObject.GetComponent<PontAndClick>().enabled = true;
        pointAndClickCheck.SetActive(true);
    }
    public void ActivateThirdPerson()
    {
        gameObject.GetComponent<thirdPersonController>().enabled = true;
        thirdPersonCheck.SetActive(true);
    }
    public void ActivateThumbStickLeft()
    {
        gameObject.GetComponent<ThumbStickContoller>().enabled = true;
        thumbStickLeft.SetActive(true);
        thumbStickLeftCheck.SetActive(true);
    }

    public void DeactivatePointAndClick()
    {
        gameObject.GetComponent<PontAndClick>().enabled = false;
        pointAndClickCheck.SetActive(false);
    }
    public void DeactivateThirdPerson()
    {
        gameObject.GetComponent<thirdPersonController>().enabled = false;
        thirdPersonCheck.SetActive(false);
    }
    public void DeactivateThumbStickLeft()
    {
        gameObject.GetComponent<ThumbStickContoller>().enabled = false;
        thumbStickLeft.SetActive(false);
        thumbStickLeftCheck.SetActive(false);
    }


}
