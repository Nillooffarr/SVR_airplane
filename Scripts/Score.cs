using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public Text Target_N;
   private static int RedplaneQ;

    // Start is called before the first frame update
    
    void Start()
    {
            RedplaneQ = RandomGen3.redplaneQ;
           Target_N.text = "You detected " + " out of " + RedplaneQ.ToString();
        }
       
    public void Back_Menu()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
