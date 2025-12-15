using UnityEngine;

/// <summary>
/// Handles the level limits
/// </summary>
public class LevelBounds : MonoBehaviour
{
    // Original position of the player
    [SerializeField] private Transform orgTransform;
    
    /// <summary>
    /// Teleports players to the origin when they leave the level bounds
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var cc = other.GetComponent<CharacterController>();
            if (cc != null) cc.enabled = false;

            other.transform.position = orgTransform.position;

            if (cc != null) cc.enabled = true;
        }
    }
}
