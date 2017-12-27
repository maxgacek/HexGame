using UnityEngine;

public class Select : MonoBehaviour {

	public bool mouseEnable = true;
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit hitInfo;

		if (Physics.Raycast(ray, out hitInfo)) {
			GameObject hitObject = hitInfo.collider.transform.gameObject;

			Debug.Log("Hit: " + hitObject.name);

			MeshRenderer mshR = hitObject.GetComponentInChildren<MeshRenderer>();

			if (Input.GetMouseButtonDown(0)) {

				mshR.material.color = Color.red;
			}
		}

		
	}
}
