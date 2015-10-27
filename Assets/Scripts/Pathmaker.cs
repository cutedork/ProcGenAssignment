using UnityEngine;
using System.Collections;

// put this on a small sphere, it will drop a "breadcrumb" trail of floor tiles


public class Pathmaker : MonoBehaviour {

	// DECLARE CLASS MEMBER VARIABLES

	public float moveSpeed = 5f; 
	int counter = 0;
	public Transform floorPrefab; 

	//4 types
	public Transform steak;
	public Transform hotdog;
	public Transform drumstick;
	public Transform toast;

	public Transform pathmakerPrefab; 


	// Update is called once per frame
	void Update () {

		if (counter < 50) {
			float randomNum = Random.Range(0.0f, 1.0f);
			//float randomNum = Random.value;

			Debug.Log (randomNum);
			if (randomNum < 0.25f) {
				// rotate 90 degrees
				transform.Rotate (0f, 90f, 0f);

				//floorPrefab = toast;

				randomNum *= 100; // make into a whole number
				randomNum = Mathf.Floor (randomNum);
				if (randomNum % 4 == 0) {
					// steak
					floorPrefab = steak;

				} else if (randomNum % 4 == 1) {
					// hotdog
					floorPrefab = hotdog;

				} else if (randomNum % 4 == 2) {
					// drumstick
					floorPrefab = drumstick;

				} else if (randomNum % 4 == 3) {
					// toast
					floorPrefab = toast;
				}




			} else if (randomNum > 0.25f && randomNum < 0.5f) {
				// rotate -90 degrees 
				transform.Rotate (0f, -90f, 0f);

				//floorPrefab = hotdog;

				randomNum *= 100; // make into a whole number
				randomNum = Mathf.Floor (randomNum);
				Debug.Log ("RANDOM NUM: " + randomNum);
				if (randomNum % 4 == 0) {
					// steak
					floorPrefab = steak;
					
				} else if (randomNum % 4 == 1) {
					// hotdog
					floorPrefab = hotdog;
					
				} else if (randomNum % 4 == 2) {
					// drumstick
					floorPrefab = drumstick;
					
				} else if (randomNum % 4 == 3) {
					// toast
					floorPrefab = toast;
				}


			} else if (randomNum > 0.99f && randomNum < 1.0f) {
				// instantiate a pathmakingPrefab clone at current position
				Instantiate(pathmakerPrefab, transform.position, transform.rotation);
			}

			// instantiate a floor prefab clone at current position;
			Instantiate (floorPrefab, transform.position, transform.rotation);

			// move foward (in local space) by 5 units; 
			transform.Translate (0f, 0f, 5f);

			counter++;

		} else {
			// destroy self;
			Destroy (this.gameObject);
		}

	
	}
}
