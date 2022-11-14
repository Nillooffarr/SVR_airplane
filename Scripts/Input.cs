using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Input : MonoBehaviour
{
    public string theNumber;
    public GameObject inputField;
    public GameObject textDisplay;
    private static int RedplaneQ;
   
        
    public void StoreNumber()
    {
        RedplaneQ = RandomGen3.redplaneQ;
        theNumber = inputField.GetComponent<Text>().text;
        if(theNumber == RedplaneQ.ToString())
        {
            textDisplay.GetComponent<Text>().text = "Congrats! You detected " + theNumber + " out of " + RedplaneQ.ToString();

        }
        else if (theNumber != RedplaneQ.ToString())
        {
            textDisplay.GetComponent<Text>().text = "You detected " + theNumber + " out of " + RedplaneQ.ToString();
        }
        else{
            textDisplay.GetComponent<Text>().text = "Please enter a number!";
        }

    }
}
