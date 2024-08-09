using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToRoomStart : MonoBehaviour
{
    [SerializeField] private string targetScene = "RoomStart"; // The name of the specific scene to load

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has collided with the door
        if (other.CompareTag("Player"))
        {
            // Load the specific scene
            LoadTargetScene();
        }
    }

    private void LoadTargetScene()
    {
        if (string.IsNullOrEmpty(targetScene))
        {
            Debug.LogError("Target scene name is not specified.");
            return;
        }

        // Load the specified scene
        SceneManager.LoadScene(targetScene);
    }
}
