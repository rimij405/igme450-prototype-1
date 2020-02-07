﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Fade animation for a CanvasGroup component.
/// </summary>
[RequireComponent(typeof(CanvasGroup))]
public class CanvasGroupFadeTarget : UIFadeTarget<CanvasGroup>, UIInteractable
{
    /// <summary>
    /// Initialize references on awake.
    /// </summary>
    void Awake()
    {
        // Get reference to the target.
        this.target = this.target ?? this.GetComponent<CanvasGroup>();
    }

    /// <summary>
    /// Assign alpha value to the actual target.
    /// </summary>
    /// <param name="target">Target to update.</param>
    /// <param name="alpha">Alpha to assign.s</param>
    protected override void UpdateTarget(float alpha)
    {
        if (this.target != null)
        {
            this.target.alpha = alpha;
        }
    }

    /// <summary>
    /// Enable group interactions.
    /// </summary>
    public void EnableInteractions() => this.SetInteractable(true);

    /// <summary>
    /// Disable group interactions.
    /// </summary>
    public void DisableInteractions() => this.SetInteractable(false);

    /// <summary>
    /// Set/unset interactable status.
    /// </summary>
    /// <param name="value"></param>
    public void SetInteractable(bool value) => this.target.interactable = value;
}