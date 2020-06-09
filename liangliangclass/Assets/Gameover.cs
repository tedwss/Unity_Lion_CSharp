using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    // 儲存分數的欄位
    string SaveScore = "SaveScore";
    public Text ScoreText;
    string SaveHeightScore = "SaveHeightScore";
    string SaveLevelID = "SaveLevelID";
    public Text HeightScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score:" + PlayerPrefs.GetFloat(SaveScore);
        HeightScoreText.text = "Height Score:" + PlayerPrefs.GetFloat(SaveHeightScore + SaveLevelID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
