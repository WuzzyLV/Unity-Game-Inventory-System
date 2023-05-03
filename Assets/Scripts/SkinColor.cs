using UnityEngine;
using UnityEngine.UI;

public class SkinColor : MonoBehaviour {
    
    [SerializeField] public Player player;
    [SerializeField] public Sprite[] sprite;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        GameManager.PlayPickupSound();
        player.SetEquipment(Player.Equipment.Head, Player.Direction.None, sprite);
    }
}
