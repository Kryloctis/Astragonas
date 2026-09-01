using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Patrol Settings")]
    public float moveSpeed = 2f;      // How fast it sways left and right
    public float moveDistance = 3f;   // How far left/right it travels

    [Header("Forward Movement (Optional)")]
    public float forwardSpeed = 0f;   // Set > 0 if you want enemies to move toward player

    private Vector3 initialSpawnPosition;
    private bool isInitialized = false;

    void OnEnable()
    {
        // Record the position the moment the object is enabled/instantiated
        initialSpawnPosition = transform.position;
        isInitialized = true;
    }

    void Update()
    {
        if (!isInitialized) return;

        // Move the base position forward/downward if forwardSpeed > 0
        if (forwardSpeed > 0f)
        {
            initialSpawnPosition += Vector3.back * forwardSpeed * Time.deltaTime;
        }

        // Calculate smooth horizontal oscillation around the spawn X position
        float xOffset = Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        // Apply updated coordinates
        transform.position = new Vector3(
            initialSpawnPosition.x + xOffset,
            initialSpawnPosition.y,
            initialSpawnPosition.z
        );

        // Auto-cleanup if it flies past the bottom of the screen
        if (transform.position.z < -15f)
        {
            Destroy(gameObject);
        }
    }

    // Call this if you manually move the object in Pause Mode to reset its anchor
    [ContextMenu("Reset Anchor Position")]
    public void ResetAnchorPosition()
    {
        initialSpawnPosition = transform.position;
    }
}