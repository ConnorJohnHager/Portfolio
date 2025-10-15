using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Attach script to main camera(s)
public class AspectRatioUtility : MonoBehaviour
{
    public Canvas[] canvases; // Assign either a single canvas or multiple

    void Start()
    {
        Adjust();
    }

    private void Update()
    {
        Adjust();
    }

    public void Adjust()
    {
        float targetaspect = 16.0f / 9.0f; // CAN CHANGE: Ratio

        float windowaspect = (float)Screen.width / (float)Screen.height;

        float scaleheight = windowaspect / targetaspect;

        Camera camera = GetComponent<Camera>();

        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;

            camera.rect = rect;
        }
        else
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }

        AdjustCanvas();
    }

    private void AdjustCanvas()
    {
        foreach (Canvas canvas in canvases)
        {
            // The Canvas RectTransform to adjust
            RectTransform canvasRect = canvas.GetComponent<RectTransform>();

            // Get the current screen size
            float screenWidth = (float)Screen.width;
            float screenHeight = (float)Screen.height;

            // Get camera's rect to align the canvas area (the visible gameplay area)
            Camera camera = GetComponent<Camera>();
            Rect cameraRect = camera.rect;

            // Calculate the non-letterboxed area (this is the actual gameplay area)
            float gameplayWidth = screenWidth * cameraRect.width;
            float gameplayHeight = screenHeight * cameraRect.height;
            float gameplayX = screenWidth * cameraRect.x;
            float gameplayY = screenHeight * cameraRect.y;

            // Set the Canvas RectTransform to match the gameplay area (excluding the letterbox areas)
            canvasRect.anchorMin = new Vector2(gameplayX / screenWidth, gameplayY / screenHeight);
            canvasRect.anchorMax = new Vector2((gameplayX + gameplayWidth) / screenWidth, (gameplayY + gameplayHeight) / screenHeight);
            canvasRect.offsetMin = Vector2.zero;
            canvasRect.offsetMax = Vector2.zero;
        }
    }
}
