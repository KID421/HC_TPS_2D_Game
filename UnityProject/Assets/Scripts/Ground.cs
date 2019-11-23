using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("移動速度"), Range(0, 200)]
    public int speed = 10;

    [Header("變型元件")]
    public Transform ground;

    private void Update()
    {
        // 呼叫方法
        Move();
    }

    // 方法 / 函式，Method / function 語法：
    // 修飾詞 方法類型 方法名稱 () { 陳述式(敘述、演算法) }
    // void 無傳回類型
    /// <summary>
    /// 地板的移動方法。
    /// </summary>
    private void Move()
    {
        // 如果 GM.遊戲結束 為 勾選 就 跳出
        if (GameManager.gameOver) return;
        // 地板.位移(x, y, z);
        // Time.deltaTime 每幀的時間
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
