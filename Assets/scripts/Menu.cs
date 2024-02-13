using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    public GameObject menuPannel;
    public GameObject pauseButton;
    public GameObject exitButton;
    public GameObject claire;
    public GameObject thumbStickLeft;

    //tick icon
    public GameObject tickPointAndClick;
    public GameObject tickThirdPerson;
    public GameObject tickThumbStickLeft;


    public void ActivateMenu()
    {
        menuPannel.SetActive(true);
        pauseButton.SetActive(false);
        exitButton.SetActive(true);
        claire.SetActive(false);
        
    }

    public void DeactivateMenu()
    {
        menuPannel.SetActive(false);
        pauseButton.SetActive(true);
        exitButton.SetActive(false);
        claire.SetActive(true);
    }

    public void ActivatePointAndClick()
    {
        claire.GetComponent<PontAndClick>().enabled = true;
        tickPointAndClick.SetActive(true);
    }
    public void ActivateThirdPerson()
    {
        claire.GetComponent<thirdPersonController>().enabled = true;
        tickThirdPerson.SetActive(true);
    }
    public void ActivateThumbStickLeft()
    {
        thumbStickLeft.SetActive(true);
        tickThumbStickLeft.SetActive(true);
    }

    public void DeactivatePointAndClick()
    {
        claire.GetComponent<PontAndClick>().enabled = false;
        tickPointAndClick.SetActive(false);
    }
    public void DeactivateThirdPerson()
    {
        claire.GetComponent<thirdPersonController>().enabled = false;
        tickThirdPerson.SetActive(false);
    }
    public void DeactivateThumbStickLeft()
    {
        thumbStickLeft.SetActive(false);
        tickThumbStickLeft.SetActive(false);
    }


}
