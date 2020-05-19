using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Range(0f, 1f)] public float Speed;

public class Player : MonoBehaviour
{
    [Range(0f, 1f)] public float Speed;
    [Header("選擇操控玩家的方法")]
    public ControlType Control;
    // 判斷是否有使用手機搖桿
    bool UseJoystick;
    // 判斷滑鼠是否點擊玩家物件
    bool MouseClick;
    public eunm ControlType
    {
        鍵盤=0, 手機陀螺儀=1, 滑鼠=2, 手機搖桿=3
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*// Input.GetKey("a")按下a鍵if條件內的腳本持續執行
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }

        // Input.GetKeyUp("d")按下d鍵且放開，if條件內的腳本執行一次
        // Input.GetKeyDown("d")按下D鍵，if鍵內的腳本執行一次
        if (Input.GetKeyUp("d")
        {
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        */
        // Input.GetAxis("Horizontal")沒有按按鍵的時候回傳值為0
        // Input.GetAxis("Horizontal")按A或是左鍵的時候回傳值為-1
        // Input.GetAxis("Horizontal")按D或是右鍵的時候回傳值為1
        // Input.GetAxis("Vertical")沒有按按鍵的時候回傳值為0
        // Input.GetAxis("Vertical")按S或是左鍵的時候回傳值為-1
        // Input.GetAxis("Vertical")按W或是右鍵的時候回傳值為1
#if UNITY_STANDALONE
        //transform.Translate(Speed * Input.GetAxis("Horizontal"), Speed * Input.GetAxis("Vertical"), 0f)
#endif

#if UNITY_ANDROID
        transform.Translate(Speed * Input.acceleration.x), Speed * acceleration.y, 0f)
#endif

        // 限制數值Mathf.Clamp(限制的項目,最大值,最小值)
        //Transform.position = new Vector3(Mathf.Clamp(Transform.position.x, -2.3f.2.3f), Mathf.Clamp(Transform.position.y, -4.6, 4.6), Transform.position.z)
    }
    // 手指剛接觸搖桿
    public void UsingJoystick()
    {
        UseJoystick = true;
    }
    // 手指離開搖桿
    public void UnUsingJoystick()
    {

    }


    // 按下滑鼠左鍵點到玩家
    void OnmouseDown()
    {
        MouseClick = true;
    }
    // 放開滑鼠左鍵
    void OnmouseUp()
    {
        MouseClick = false;
    }

}
