using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public void Level()
    {
        {
            SceneManager.LoadScene("Area1");
        }
    }

    public void LevelForest()
    {
        {
            SceneManager.LoadScene("Forest");
        }
    }
}

