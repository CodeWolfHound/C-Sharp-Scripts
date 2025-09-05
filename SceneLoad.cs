using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 1f;
    public void DelayScene()
    {
        StartCoroutine(WaitAndLoad());
    }
    public void LoadSceneByName()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("Tavern");
    }
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Tavern");
    }
}
