using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    [Header("血量"), Range(100, 1000)]
    public float hp;
    [Header("血條")]
    public Image hpbar;

    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }

    /// <summary>
    /// 接收傷害值
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        hp -= damage;                       // 血量 遞減 傷害值
        hpbar.fillAmount = hp / hpMax;      // 更新 血條
    }
}
