using UnityEngine;
public class ItemInteractScript : MonoBehaviour
{
    //Interaction button
    [SerializeField] private GameObject interaction;

    //If collision is being touched 
    private bool checkState = false;
    //Sound Sources
    public AudioSource sound1;
    public AudioSource sound2;

    void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if the player tag is touching the item
        if (other.CompareTag("Player"))
        {

            Debug.Log("Touching");
            interaction.SetActive(true);
            checkState = true;


        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            checkState = false;
        interaction.SetActive(false);
        Debug.Log("Leaving");

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && sound1 == null)
        {
            Debug.Log("No SOund");

        }

        if (Input.GetKeyDown(KeyCode.E) && checkState == true)
        {
            Debug.Log("Press");
            PlaySoundOne();
        }
    }
    private void PlaySoundOne()
    {
        sound1.Play();
    }
}
