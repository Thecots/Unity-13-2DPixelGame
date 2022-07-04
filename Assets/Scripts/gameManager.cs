using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;

    private void Awake()
    {
        PlayerPrefs.SetInt("score", 0);
        score.text = PlayerPrefs.GetInt("score", 0).ToString();
    }

    public void AddScore()
    {
        Debug.Log("hika");
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score", 0) + 1);
        score.text = PlayerPrefs.GetInt("score", 0).ToString();
    }
}
