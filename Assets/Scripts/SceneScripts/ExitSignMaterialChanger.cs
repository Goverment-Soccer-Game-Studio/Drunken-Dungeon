using UnityEngine;

public class ExitSignMaterialChanger : MonoBehaviour
{
    [SerializeField] private Material regularMaterial;
    [SerializeField] private Material rewardMaterial;
    [SerializeField] private Material bossMaterial;

    private Renderer renderer;

    void Start()
    {
        // Get the Renderer component attached to the ExitSign GameObject
        renderer = GetComponent<Renderer>();

        // Update the material based on the initial value of roomCounter
        UpdateMaterial(DoorTeleport.GetRoomCounter());
    }

    // Call this method to update the material
    public void UpdateMaterial(int currentRoomCounter)
    {
        if (renderer != null)
        {
            int nextRoomCounter = currentRoomCounter + 1;

            if (nextRoomCounter % 10 == 0 && bossMaterial != null)
            {
                // Change to boss material (next room is a boss room)
                renderer.material = bossMaterial;
            }
            else if (nextRoomCounter % 3 == 0 && rewardMaterial != null)
            {
                // Change to reward material (next room is a reward room)
                renderer.material = rewardMaterial;
            }
            else if (regularMaterial != null)
            {
                // Change to regular material (next room is a regular room)
                renderer.material = regularMaterial;
            }
        }
    }
}
