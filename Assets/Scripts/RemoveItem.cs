using UnityEngine;
using UnityEngine.EventSystems;

public class RemoveItem : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData)
	{
		//todo finish garbo
		Slot slot = GetComponent<Slot>();
		slot.image.sprite = null;
		slot.image.enabled = false;

		foreach (var equipment in slot.equipment)
		{
			GetComponent<Slot>().GetPlayer().RemoveEquipment(equipment, slot.direction);
		}
	}
}
