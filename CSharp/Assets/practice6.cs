﻿using UnityEngine;

public class practice6 : MonoBehaviour
{
    // 欄位
    // 修飾詞 類別 物件名稱
    public SpriteRenderer kid;

    public Rigidbody ball;

    private void Start()
    {
        // 練習1 : 靜態屬性
        Time.timeScale = 2;

        // 練習2 非靜態屬性
        kid.flipX = true;

        // 練習3 : 靜態方法
        print(Mathf.Floor(1.23456f));

        // 練習4 : 非靜態方法
        ball.AddForce(0, 500, 1500);
    }
}
