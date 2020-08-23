using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene(1);
    }
}

