using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    [Header("下一個關卡的名稱")]
    public string NextSceneName;
    public int LevelID;
    public Text Leveltext;
    [Header("設定每個關卡最高得分數")]
    public float SetHeightScore;
    // 儲存每個關卡最高得分數
    string SaveHeightScore = "SaveHeightScore";
    string SaveLevelID = "SaveLevelID";

    private void Start()
    {
        if(Application.loadedLevelName == "Level" && GetComponentInChildren<Text> != null)
        {
            // 抓去子物件
            Leveltext = GetComponentInChildren<Text>();
            // 字串轉成整數直
            LevelID = int.Parse(Leveltext.text);
        }
    }


    public void NextScene()
    {
        // 如果場景名稱為Menu
        if(NextSceneName == "Menu")
        {
         // Destroy刪除物件
            Destroy(GameObject.Find("BGM").gameObject);
        }
        if (NextSceneName == "Movie")
        {
            PlayerPrefs.SetFloat(SaveLevelID, LevelID);
            // 跳關卡到Game畫面前，先將每關最高得分數儲存
            PlayerPrefs.SetFloat(SaveHeightScore + LevelID, SetHeightScore);
            // GameObject.Find(物件名稱).SetActive判斷物件是否要開啟
            // GameObject.Find(物件名稱).SetActive(false);
            // GameObject.Find(物件名稱).GetComponent<元件名稱>().enable判斷物件身上的元件是否要開啟
            GameObject.Find("BGM").GetComponent<AudioSource>().enabled = false;
        }
        if (NextSceneName == "Game")
        {

            // GameObject.Find("BGM").SetActive(true);
            GameObject.Find("BGM").GetComponent<AudioSource>().enabled = true;
        }
        Application.LoadLevel(NextSceneName);
    }
}
