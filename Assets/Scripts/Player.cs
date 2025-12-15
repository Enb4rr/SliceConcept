using System;
using System.Collections.Generic;
using Objects;
using UnityEngine;

/// <summary>
/// Player's class
/// </summary>
public class Player : MonoBehaviour
{
    // Components
    [SerializeField] private List<Key> lostKeys = new List<Key>();
    
    private List<int> collectedKeys;
    
    // Accessors
    public List<int> CollectedKeys => collectedKeys;
    
    // Events
    public Action<int> onKeyPickedUp;

    private void Awake()
    {
        // Initialize keys to collect
        collectedKeys = new List<int>();
    }

    private void Start()
    {
        // Subscribe events to collected keys
        foreach (var key in lostKeys)
        {
            key.OnKeyPickedUp += ReceiveKey;
        }
    }

    // Handles the logic used when receiving a key
    private void ReceiveKey(int newKey)
    {
        if (!collectedKeys.Contains(newKey))
        {
            // Add key to collected keys
            collectedKeys.Add(newKey);
            // Call collected event
            onKeyPickedUp?.Invoke(collectedKeys.Count);
        }
    }
}