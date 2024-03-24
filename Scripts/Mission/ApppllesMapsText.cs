using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;


public class ApppllesMapsText : MonoBehaviour
{
    Text text;
    public static int apple;
    public int numberScenes;
    private string Elif = "Info.txt";

    void Start()
    {
        text = GetComponent<Text>();
        apple = 0;
        
    }


    void Update()
    {
        text.text = apple.ToString() + "/12";

        if (apple == 12)
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

        using (FileStream fs = new FileStream(Elif, FileMode.OpenOrCreate | FileMode.Truncate))
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
