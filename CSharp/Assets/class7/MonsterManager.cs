using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [Header("怪物陣列 0 狐狸 1老鷹 2老鼠 3青蛙")]
    public GameObject[] monster;

    /// <summary>
    /// 生成怪物
    /// </summary>
    /// <param name="index"></param>
    public void CreateMonster(int index)
    {
        Instantiate(monster[index], new Vector3(-10, 2, 0), Quaternion.identity);
    }
}
