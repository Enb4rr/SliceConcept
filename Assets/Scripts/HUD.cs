using System.Collections.Generic;
using DG.Tweening;
using Managers;
using UnityEngine;

/// <summary>
/// Manages the HUD of the game
/// </summary>
public class HUD : BaseManager<HUD>
{
    [SerializeField] private List<CanvasGroup> keyIcons;

    /// <summary>
    /// Fills an icon when a key is collected
    /// </summary>
    /// <param name="index"></param>
    public void FillIcon(int index)
    {
        if (keyIcons[index] != null)
            keyIcons[index].DOFade(1, 0.5f);
    }
}
