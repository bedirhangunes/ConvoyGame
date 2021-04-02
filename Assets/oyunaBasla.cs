using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class oyunaBasla : MonoBehaviour
{
   public void started()
    {
        SceneManager.LoadScene("level");
    }
    public void exited()
    {
        Application.Quit();
    }
}
