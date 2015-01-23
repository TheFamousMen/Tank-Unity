using UnityEngine;
using System.Collections;

public class RotationTurret : MonoBehaviour {

	public Camera camera;
	private Transform[] transforms;
	// Use this for initialization
	void Start () {
		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms) {
				
			if (t.gameObject.name == "turret")
			{
				turret = t;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition; //(x,y,z)
		mousePos.z = camera.transform.position.y;

		Vector3 worldPos camera.ScreenToWorldPoint (mousePos);
		turret.LookAt(worldPos);



	}
}
