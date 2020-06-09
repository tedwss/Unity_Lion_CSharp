using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    [Header("子彈多久被消滅")]
    public float DeleteTime;
    [Header("爆炸音效")]
    public AudioSource EffectAudio;
    // Start is called before the first frame update
    void Start()
    {

        // Destroy(要刪除的物件(型態只能為GameObject), 多久以後物體自己毀滅);
        // gameObject 誰有此腳本就代表誰
        Destroy(gameObject, DeleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3.up = (0,1,0) Vector3.down = (0,-1,0), Vector3.forward(1,0,0)
        // transfrom.Translate(0, Speed, 0);
        transform.Translate(Vector3.up * Speed);
    }
    // 穿透型觸碰方式 OntriggerEnter, OnTriggerStay, OntriggerExit
    // 不穿透型碰撞 OnCollosionEnter, OnCollosionStay, OnCollosionExit
    // Enter 兩個物件一相撞，Function內的程式只會執行一次
    // Stay 兩個物件一相撞，沒有分開，Function內的程式會持續執行，直到兩個物件分離
    // Exit 兩個物件一相撞且分開，Function內的程式只會執行一次

    private void OnTriggerEnter2D(Collider2D other) // collision
    {
        // 玩家的子彈打到有Collider2D的物件，就該檢測該物件的標籤是否有Enemy
        if (other.Getcomponent<Collider2D>().tag == "Emeny" && gameObject.tag == "PlayerBullet")
        {
            // 動態生成爆炸特效
            // other.transform.position兩個物件碰撞的位置
            // other.transform.rotation兩個物件碰撞的旋轉值
            Instantiate(Effect, other.transform.position, other.transform.rotation);
            // 玩家子彈打到敵機，玩家加分
            GameObject.FindGameObjectsWithTag("Player").GetComponent<Player>().Score();
            // 爆炸音效
            EffectAudio.Play();
            // 敵機消滅
            Destroy(other.gameObject);
            // 自己子彈物件被消滅
            Destroy(gameObject);

            // 玩家打到敵機
            if(other.GetComponet<Collider2D>().tag == "EnemyBullet" && gameObject.tag == "playerBullet")
            {
                Destroy(other.gameobject);
                Destroy(gameObject);
            }
            // 敵機子彈打到玩家
            if (other.GetComponet<Collider2D>().tag == "EnemyBullet" && gameObject.tag == "playerBullet")
            {
                // 敵機打到玩家，呼叫玩家物件身上的player腳本中的HurtPlayer進行扣血
                other.GetComponent<Player>().HurtPlayer(10)
            }
        }
    }

}
