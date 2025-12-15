using System;
using UnityEngine;

namespace Managers
{
    public class GameManager : BaseManager<GameManager>
    {
        [Header("Game Settings")] 
        [SerializeField] private int amountOfKeysToCollect = 3;
        
        [Header("Scene Settings")]
        [SerializeField] private string levelKeyCode;
        [SerializeField] private string mainSceneKeyCode;
        
        [Header("Components")]
        [SerializeField] private Player player;
        [SerializeField] private PlayerController playerController;
        
        public Player Player => player;
        public PlayerController PlayerController => playerController;
        public string LevelKeyCode => levelKeyCode;
        public string MainSceneKeyCode => mainSceneKeyCode;
        

        public event Action OnGameOver;

        private void Start()
        {
            // Subscribe to player events
            player.onKeyPickedUp += EvaluateGameplayState;
        }

        /// <summary>
        /// Evalutes gameplay state depending on progress
        /// </summary>
        /// <param name="collectedKeys"></param>
        private void EvaluateGameplayState(int collectedKeys)
        {
            if (collectedKeys < amountOfKeysToCollect) return;
            OnGameOver?.Invoke();
        }
    }
}
