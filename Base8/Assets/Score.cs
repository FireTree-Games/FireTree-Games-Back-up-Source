using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText,comboText,missText,finishScoreText,finishComboText,finishMissText, noteText, finishNoteText;
    public float score;
    public int Combo;
    public int Misses;
    public int totalNotes;
    public float accuracy;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        comboText.text = "Combo: " + Combo.ToString();
        finishScoreText.text = "Score: " + score.ToString();
        finishComboText.text = "Combo: " + Combo.ToString();
        missText.text = "Misses: " + Misses.ToString();
        finishMissText.text = "Misses: " + Misses.ToString();
        noteText.text = "Accuracy: " + accuracy.ToString();
        finishNoteText.text = "Accuracy: " + accuracy.ToString();
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}
