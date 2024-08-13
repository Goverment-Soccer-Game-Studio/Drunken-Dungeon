using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTeleport : MonoBehaviour
{
    [SerializeField] private string[] sceneNames; // List of regular scene names
    [SerializeField] private string[] rewardSceneNames; // List of reward scene names
    [SerializeField] private string[] bossSceneNames; // List of boss scene names

    private static int roomCounter = 0; // Counter to keep track of the number of rooms loaded

    public void LoadNextScene()
    {
        if (sceneNames.Length == 0)
        {
            Debug.LogError("No scenes specified in the sceneNames array.");
            return;
        }

        string nextScene;

        // Increment room counter
        roomCounter++;

        // Get the ExitSignMaterialChanger component from the ExitSign object
        ExitSignMaterialChanger exitSignChanger = GameObject.Find("ExitSign").GetComponent<ExitSignMaterialChanger>();
        if (exitSignChanger != null)
        {
            // Update the ExitSign material based on the new roomCounter value
            exitSignChanger.UpdateMaterial(roomCounter);
        }

        // Determine the type of room to load based on the counter
        if (roomCounter % 10 == 0 && bossSceneNames.Length > 0)
        {
            // Load a boss room every 10 rooms
            int randomIndex = Random.Range(0, bossSceneNames.Length);
            nextScene = bossSceneNames[randomIndex];
        }
        else if (roomCounter % 3 == 0 && rewardSceneNames.Length > 0)
        {
            // Load a reward room every 3 rooms
            int randomIndex = Random.Range(0, rewardSceneNames.Length);
            nextScene = rewardSceneNames[randomIndex];
        }
        else
        {
            // Load a regular room
            int randomIndex = Random.Range(0, sceneNames.Length);
            nextScene = sceneNames[randomIndex];
        }

        // Load the chosen scene
        SceneManager.LoadScene(nextScene);
    }

    // Add this method to allow the ExitSignMaterialChanger to access the roomCounter
    public static int GetRoomCounter()
    {
        return roomCounter;
    }
}
