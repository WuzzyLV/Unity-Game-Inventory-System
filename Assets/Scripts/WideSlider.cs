using UnityEngine;

public class WideSlider : MonoBehaviour {
	[SerializeField] public GameObject player;
	
	private void Awake()
	{
		GetComponent<UnityEngine.UI.Slider>().onValueChanged.AddListener(OnValueChanged);
	}

	private Vector3 scale;
	void OnValueChanged(float value)
	{
		scale = player.transform.localScale;
		scale.x = value;
		player.transform.localScale = scale;
	}
	
	
}
