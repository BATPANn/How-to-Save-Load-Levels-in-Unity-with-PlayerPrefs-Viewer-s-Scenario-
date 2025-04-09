using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveThisSceneYoutube : MonoBehaviour
{
    

    public void SaveThisSceneVoid()
    {


        PlayerPrefs.SetString("LastLevel", SceneManager.GetActiveScene().name);

        Debug.Log("Saved" + " We are on scene : " + SceneManager.GetActiveScene().name);


        


    }



}
