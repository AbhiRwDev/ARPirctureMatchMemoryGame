using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance;

    private void Awake()
    {
        // Check if an instance already exists
        if (instance != null && instance != this)
        {
            // Destroy the duplicate object
            Destroy(gameObject);
            return;
        }

        // Set this object as the instance and prevent it from being destroyed
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
