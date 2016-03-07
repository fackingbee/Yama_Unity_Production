using UnityEngine;
using System.Collections;

public class BoardMove : MonoBehaviour {

	// 時間管理用 //
	// For managing time //
	private float time;

	// Use this for initialization
	void Start () {

		// timeを初期化 //
		// Initialize "time" value //
		time = 0;

	}
	
	// Update is called once per frame
	void Update () {

		// timeを更新 //
		// Update the time //
		time += Time.deltaTime;

		// Boardを時間に応じて自動移動 //
		// Auto moving for Board at the time. //
		transform.localPosition = new Vector3( 0, - time * 100, 0 );

	}
}
