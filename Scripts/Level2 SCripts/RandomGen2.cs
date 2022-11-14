using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RandomGen2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Target_N;
    public GameObject Airplanered;
    public GameObject Airplaneblue;
    public GameObject Airplanepink;
    public int xPos;
    public int zPos;
    public int yPos;
    public int yRot;
    public static int SceneC = 0;
    public int objectToGenerate;
    public int objectQuantity; // to cap the number of objects
    public static int redplaneQ = 0;
    public float startTime;
    public float elapsedTime;
    public float timer;
    void Start()
    {
        SceneC = 1;
        startTime = Time.time;
        Invoke("Begin", 2);
        //Target_N = GetComponent<Text>();

    }
    public void Begin()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {

        elapsedTime = Time.time - startTime;
        while (Time.time < ((5.0f) + elapsedTime))
        {
            objectToGenerate = Random.Range(1, 4);
            xPos = Random.Range(17, -33); //+1
            zPos = Random.Range(-16, 33);
            yPos = Random.Range(1, 8);
            yRot = Random.Range(-100, 14);
            if (objectToGenerate == 1)
            {
                Instantiate(Airplaneblue, new Vector4(17, yPos, zPos, yRot), Quaternion.Euler(0, yRot, 0));
            }
            if (objectToGenerate == 2)
            {
                Instantiate(Airplanered, new Vector3(17, yPos, zPos), Quaternion.Euler(0, yRot, 0));
                redplaneQ += 1;
            }
            if (objectToGenerate == 3)
            {
                Instantiate(Airplanepink, new Vector3(17, yPos, zPos), Quaternion.Euler(0, yRot, 0));
            }
            yield return new WaitForSeconds(0.5f);
            objectQuantity += 1;
        }

        //Target_N.text = redplaneQ.ToString();
        Debug.Log(redplaneQ.ToString());
        Invoke("NextScene", 4);
    }


    // Update is called once per frame
    void NextScene()
    {
        SceneManager.LoadScene(4);
    }

}
