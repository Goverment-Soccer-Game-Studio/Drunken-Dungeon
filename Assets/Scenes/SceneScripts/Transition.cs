using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTeleport : MonoBehaviour
{
    [SerializeField] private string[] sceneNames; // List of scene names to choose from

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has collided with the door
        if (other.CompareTag("Player"))
        {
            // Load a random scene from the list
            LoadRandomScene();
        }
    }

    public void LoadRandomScene()
    {
        if (sceneNames.Length == 0)
        {
            Debug.LogError("No scenes specified in the sceneNames array.");
            return;
        }

        // Pick a random scene from the list
        int randomIndex = Random.Range(0, sceneNames.Length);
        string randomScene = sceneNames[randomIndex];

        // Load the chosen scene
        SceneManager.LoadScene(randomScene);
    }
}