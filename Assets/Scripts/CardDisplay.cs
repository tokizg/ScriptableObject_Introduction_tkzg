using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    // 表示するカードデータ
    [SerializeField] private SingleCard cardData;
    
    // カード表示用のUI要素たち
    [SerializeField] private TextMesh cardNameText;
    [SerializeField] private SpriteRenderer cardImageRenderer;
    [SerializeField] private TextMesh cardCostText;
    [SerializeField] private TextMesh cardDescriptionText;

    // カードデータがnullの場合に表示するデフォルトの値
    [SerializeField] private Sprite defaultSprite;
    
    void Start()
    {
        if (cardData == null)
        {
            Debug.Log("カードのデータが設定されていません.");
            return;
        }

        // カードデータをUI要素に反映していく
        
        // カード名を設定
        cardNameText.text = cardData.cardDisplayName;
        // 使用コスト値を設定
        cardCostText.text = cardData.usingCost.ToString();
        // カード説明を設定
        cardDescriptionText.text = cardData.cardDescription;
        
        // カード画像が設定されていない場合はデフォルトの画像を使用
        if(cardData.cardImage == null)
        {
            cardImageRenderer.sprite = defaultSprite;
        }
        // 画像が設定されている場合はその画像を使用
        else
        {
            cardImageRenderer.sprite = cardData.cardImage;
        }
    }
    
    // UI要素の描画順を調整するためにAwakeで設定
    void Awake()
    {
        cardNameText.GetComponent<MeshRenderer>().sortingLayerName = "Text";
        cardCostText.GetComponent<MeshRenderer>().sortingLayerName = "Text";
        cardDescriptionText.GetComponent<MeshRenderer>().sortingLayerName = "Text";
    }
}
