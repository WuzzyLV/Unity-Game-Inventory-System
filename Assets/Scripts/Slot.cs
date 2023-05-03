using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{

    [SerializeField] public Image image;
    [SerializeField] public GameObject playerGameObject;
    [SerializeField] public Player.Equipment[] equipment;
    [SerializeField] public Player.Direction direction;

    private Player _player;
    private void Awake()
    {
        _player = playerGameObject.GetComponent<Player>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem item= eventData.pointerDrag.GetComponent<InventoryItem>();
        if (!equipment.Contains(item.equipment))
            return;
        
        image.enabled = true;
        image.sprite = item.sprite[0];
        _player.SetEquipment(item.equipment, direction, item.sprite);
    }


    public Player GetPlayer()
    {
        return _player;
    }
}
