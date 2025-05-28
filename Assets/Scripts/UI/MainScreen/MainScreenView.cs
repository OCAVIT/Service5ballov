using UnityEngine;
using UnityEngine.UI;
using System;

public class MainScreenView : MonoBehaviour
{
    [SerializeField] private Button openButton;

    public void SubscribeOnOpen(Action action) => openButton.onClick.AddListener(() => action());
    public void UnsubscribeOnOpen(Action action) => openButton.onClick.RemoveListener(() => action());
    public void SetInteractable(bool interactable) => openButton.interactable = interactable;
}