using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Movie : MonoBehaviour
{
    public VideoPlayer Movie_;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        //依照時間順序呼叫function
        //InvokeRepeating(function名稱，遊戲一開始要等待幾秒才進行第一次呼叫，第二次、第三次...需要等待幾秒做呼叫);
        InvokeRepeating("CheckMovie", 3f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Timer = Timer + 0.1f;
        //Timer += 0.1f;
        /*Timer += Time.deltaTime;
        if (Timer > 3f)
        {
            //Movie_.isPlaying = true 影片還沒播放結束
            //Movie_.isPlaying = false 影片播放結束
            if(Movie_.isPlaying == false)
            {
                Application.LoadLevel("Game");
            }
        }*/
    }
}
