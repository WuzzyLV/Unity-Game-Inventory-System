using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] public Canvas canvas;
    [SerializeField] public Player.Equipment equipment;

    private RectTransform _rectTransform;
    private CanvasGroup _canvasGroup;
    
    public Vector2 originalPosition;
    
    public Sprite[] sprite;
    
    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
        
        originalPosition = _rectTransform.anchoredPosition;
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        GameManager.PlayPickupSound();
        _canvasGroup.blocksRaycasts=false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameManager.PlayDropSound();
        _canvasGroup.blocksRaycasts = true;
        _rectTransform.anchoredPosition = originalPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("anch");
        _rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}
