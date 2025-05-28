using UnityEngine;
using UnityEngine.UI;
using System;

public class PanelScreenView : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] private Button collectButton;
    [SerializeField] private Text scoreText;
    [SerializeField] private Image panelImage;

    public void SubscribeOnClose(Action action) => closeButton.onClick.AddListener(() => action());
    public void UnsubscribeOnClose(Action action) => closeButton.onClick.RemoveListener(() => action());

    public void SubscribeOnCollect(Action action) => collectButton.onClick.AddListener(() => action());
    public void UnsubscribeOnCollect(Action action) => collectButton.onClick.RemoveListener(() => action());

    public void SetScore(int score) => scoreText.text = score.ToString();
    public Image PanelImage => panelImage;
}