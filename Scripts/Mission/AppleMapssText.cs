using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class AppleMapssText : MonoBehaviour
{
    Text text;
    public static int applee;
    public int numberScenes;
    private string File = "Info.txt";

    void Start()
    {
        text = GetComponent<Text>();
        applee = 0;
       
    }


    void Update()
    {
        text.text = applee.ToString() + "/28";

        if (applee == 28)
        {
            SceneChangers();
        }


    }


    void SceneChangers()
    {

        LevelUnLock();
        SaveText();
        SceneManager.LoadScene(0);

    }

    public void LevelUnLock()

    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;


        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }


    }
    public void SaveText()
    {

        using (FileStream fs = new FileStream(File, FileMode.OpenOrCreate | FileMode.Truncate))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < 3; i++)
                {


                    if (numberScenes-- != 0)
                    {
                        sw.WriteLine("1");
                    }

                    else
                    {
                        sw.WriteLine("0");
                    }

                }

            }
        }
    }

}
