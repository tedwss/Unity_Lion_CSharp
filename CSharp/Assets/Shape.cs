using UnityEngine;

public class Shape : MonoBehaviour
{
    /// <summary>
    /// 形狀 : 基底類別
    /// </summary>
    [Header("長、寬、高")]
    public float length;
    public float width;
    public float height;

    /// <summary>
    /// 體積
    /// protected 保護 : 允許子類別存取，禁止外部存取
    /// </summary>
    protected float volume;

    /// <summary>
    /// 取得體積
    /// virtual 虛擬 : 允許子類別覆寫
    /// </summary>
    /// <returns></returns>
    public virtual float GetVolume()
    {
        volume = length * width * height;
        return volume;
    }

}
