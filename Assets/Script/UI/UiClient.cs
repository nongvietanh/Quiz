using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiClient : MonoBehaviour
{
    public Image image;
    public Canvas canvas;

    private float _imageWidth;
    private float _imageHeight;
    private float _canvasWidth;
    private float _canvasHeight;

    void Start()
    {
        _imageWidth = image.rectTransform.sizeDelta.x;
        _imageHeight = image.rectTransform.sizeDelta.y;
        _canvasWidth = 1920;
        _canvasHeight = 1080;
        Updatea();
    }
    float targetWidth, targetHeight;
    void Updatea()
    {
        int numParticipants = 5;

        if (numParticipants == 1)
        {
            targetWidth = _canvasWidth;
            targetHeight = _canvasHeight;
        }
        else
        {
            float aspectRatio = _canvasWidth / _canvasHeight;
            targetWidth = _canvasWidth / numParticipants;
            targetHeight = targetWidth / aspectRatio;
        }

        float xOffset = (_canvasWidth - targetWidth) / (numParticipants - 1);
        float yOffset = (_canvasHeight - targetHeight) / (numParticipants - 1);

        image.rectTransform.anchoredPosition = new Vector2(
            xOffset * (numParticipants - 1),
            yOffset * (numParticipants - 1)
        ) + image.rectTransform.anchoredPosition;

        image.rectTransform.sizeDelta = new Vector2(
            targetWidth,
            targetHeight
        );
    }
}
