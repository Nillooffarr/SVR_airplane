using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menuscript : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    
    public void Level1_play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Level1");
    }
    public void Level2_play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        SceneManager.LoadScene("Level2");
    }
    // Start is called before the first frame update
    public void Level3_play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        SceneManager.LoadScene("Level3");
    }
    
    // Update is called once per frame
    void Update()
    {

    }

}
