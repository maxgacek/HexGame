using UnityEngine;

public class Map : MonoBehaviour {

	public GameObject Hex;

	int height = 9;
	int width = 9;

	float xFix = 1.8f;
	float yFix = 2f;

	float xOff = 0.88f;
	float yOff = 0.77f;

	void Start () {
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xFix;
				float yPos = y * yFix;

				if (y % 2 == 1) {
					xPos += xOff;
				}

				GameObject hex = (GameObject)Instantiate(Hex, new Vector3(xPos, 0, yPos * yOff), Quaternion.identity);

				hex.name = "Hex_" + x + "_" + y;

				hex.GetComponent<Hex>().x = x;
				hex.GetComponent<Hex>().y = y;
		
				hex.transform.SetParent(this.transform);
			}
		}
	}
}
