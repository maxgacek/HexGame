using UnityEngine;

public class Hex : MonoBehaviour {

	public int x;
	public int y;

	public Hex[] GetNieghbours() {

		GameObject leftN = GameObject.Find("Hex_" + (x - 1) + "_" + y);

		return null;
	}
}
