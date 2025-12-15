using Managers;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handles Main Menu
/// </summary>
public class Menu : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private string gameplaySceneKeyCode;
    [SerializeField] private Button playButton;
    
    private void Start()
    {
        // Subscribe button to load main scene
        playButton.onClick.AddListener(LoadGameplayScene);
    }

    /// <summary>
    /// Loads the gameplay level scene
    /// </summary>
    private void LoadGameplayScene()
    {
        LoadingScreenManager.Instance.LoadScene(gameplaySceneKeyCode);
    }
}
