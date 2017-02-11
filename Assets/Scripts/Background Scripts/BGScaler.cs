using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	void Start () {
		var worldHeight = Camera.main.orthographicSize * 2f;
//		Debug.Log (worldHeight);
//		Debug.Log (Screen.width);
//		Debug.Log (Screen.height);
		var worldWidth = worldHeight * Screen.width / Screen.height;
		transform.localScale = new Vector3 (worldWidth, worldHeight, 0);

	}

}
