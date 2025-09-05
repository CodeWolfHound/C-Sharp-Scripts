using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteractionScript : MonoBehaviour
{
    //Interaction button
    [SerializeField] private GameObject interaction;

    //Index Tracker
    private int currentIndex = 0;

    //check if collision is being touched 
    private bool checkState = false;

    //Sources
    public NPC_UI_Manager manager;
    public PlayerMovement playerMovement;

   
    private void Update()
    {
        //Checks if E key in pressed and player is in colider
        if (Input.GetKeyDown(KeyCode.E) && checkState == true)
        {
            ChatDialougeInteraction();
            manager.dialoguePanel.SetActive(true);
            playerMovement.StopMoving();
        }
        //Checks if Space key is pressed ++
        else if (Input.GetKeyDown(KeyCode.Space) && checkState == true)
        {
            //Debug.Log("Space");
            currentIndex++;
            ChatDialougeInteraction();
            //Debug.Log(currentIndex);
        }
        //Checks if Q key in pressed and player is in colider
        else if (Input.GetKeyDown(KeyCode.Q) && checkState == true)
        {
            manager.dialoguePanel.SetActive(false);
            playerMovement.AllowMoving();
            currentIndex = 0;
        }

        
    }
    //Enables NPC UI Gameobject and inserts string data from selected asset file
    public void ChatDialougeInteraction()
    {
        
        //Checks if dialouge box and dialouge lines are both set 
        if (manager.dialgoueText != null && manager.dialogueData.dialougeLines != null)
        {  
            //Checks index count is starting at the beggining and is less than the length  
            if (currentIndex < manager.dialogueData.dialougeLines.Length)
            {
                manager.nameText.text = manager.dialogueData.npcName;
                manager.dialgoueText.text = manager.dialogueData.dialougeLines[currentIndex];
                manager.npcPortrait.sprite = manager.dialogueData.npcSprite;
                //currentIndex++;
            }
            else
            {
                Debug.Log("Index has passed dialougelines");
            }
        }
        else 
        {
            
            Debug.Log("No Dialouge found");
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {

            Debug.Log("Touching");
            //enables game object to show on screen
            interaction.SetActive(true);
            checkState = true;


        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        //Checks if the player tag is touching the item
        if (other.CompareTag("Player"))
        {
            checkState = false;
            //Diables game object on screen
            interaction.SetActive(false);
            Debug.Log("Leaving");
        }
    }
