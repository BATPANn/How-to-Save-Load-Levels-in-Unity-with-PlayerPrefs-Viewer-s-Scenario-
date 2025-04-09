using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLastLevelYoutue : MonoBehaviour
{
    


    public void LoadLastLevelVoid()
    {


        string LastLevelName = PlayerPrefs.GetString("LastLevel");

        SceneManager.LoadScene(LastLevelName);



    }


}
