using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("設定幾秒產生一顆子彈")]
    public float CreateTime;
    [Header("子彈物件")]
    public GameObject Bullet;
    [Header("子彈生成點")]
    public Transform createObject;
    public AudioSource ShootingSound;
    // Start is called before the first frame update
    void Start()
    {
        ShootingSound = GameObject.Find("Shoot").GetComponent<>
        InvokeRepeating("CreateBullet", CreateTime, CreateTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void creatBullet()
    {
        // 穿透型碰撞 : 物件穿透另一個物件, ex : 玩家用劍穿透另一個NPC。
        // 不穿透型碰撞 : 物件部穿透另一個物件, ex : 玩家行走在地面(遊戲平台)上。
        // 動態生成 : Instantiate(要生成的物件,生成出來以後的物件位置,生成出來以後的物件角度);
        Instantiate(Bullet, createObject.position,createObject.rotation);
    }
}
