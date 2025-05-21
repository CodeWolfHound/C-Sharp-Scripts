using UnityEditor;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public AudioSource MenuObject;
    private bool musicIsPaused = true;

    public void PauseMusicOnClick()
    {
        if (musicIsPaused == true)
        {
            MenuObject.Pause();
            musicIsPaused=false;

        }
        else
        {
           
            MenuObject.Play();
            musicIsPaused = true;
        }
         
        
    }
}
