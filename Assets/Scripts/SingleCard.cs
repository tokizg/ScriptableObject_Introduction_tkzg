using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Single Card", menuName = "Card Game/Single Card")]
public class SingleCard : ScriptableObject
{
    // カード表示名
    public string cardDisplayName = "新しいカード";
    // カード画像
    public Sprite cardImage;        
    // 使用コスト値
    public uint usingCost = 1;
    // カード説明
    [TextArea]
    public string cardDescription = "カードの説明";
}