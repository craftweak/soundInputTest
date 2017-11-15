using UnityEngine;
using System.Collections;

public class Tool_SelfKill : MonoBehaviour {

	[SerializeField]private float SelfKillAfterSeconds;
	private float timer = 0f;
	void Update () {
		timer += Time.deltaTime;
		if (timer > SelfKillAfterSeconds) {
			Destroy (gameObject);
		}
	}
}
