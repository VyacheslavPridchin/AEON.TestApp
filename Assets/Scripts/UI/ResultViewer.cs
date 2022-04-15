using System;
using UnityEngine;
using UnityEngine.UI;

public class ResultViewer : MonoBehaviour
{
    [SerializeField]
    private bool showCurrentResult = false;
    [SerializeField]
    private Text UICurrentResult;
    [SerializeField]
    private Text UIOldResult;

    private void OnEnable()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (showCurrentResult)
        {
            TimeSpan currentResult = GameController.Instance.CurrentResult;

            UICurrentResult.text = "���������: ";
            UICurrentResult.text += $"{currentResult.Minutes} ���. ";
            UICurrentResult.text += $"{currentResult.Seconds} ���. ";
            UICurrentResult.text += $"{currentResult.Milliseconds} ��. ";
        }

        UIOldResult.text = SaveManager.GetResults();

    }
}
