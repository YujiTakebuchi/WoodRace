using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {
	int j = 0;
	public float speedRate;
	public float rotateRate;
	public Rigidbody rb;
	PlayerController pc = new PlayerController();
	public Text kinoko_text;

	// Use this for initialization
	void Start () {
		kinoko_text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotateRate,0,Space.World);
	}

	void OnTriggerEnter (Collider collider) {
		if (this.gameObject.tag == "WoodBranch") {
			pc.chengePoint(1);
			setRateByPoint ();
		}

		if (this.gameObject.tag == "Mushroom") {
			PlayerController.setItem("Mushroom");
		}

		if (this.gameObject.tag == "Goal") {
			Debug.Log ("Goal");
		}
//		kinoko_text.text = "きのこ: ";
//		kinoko_text.text += PlayerController.getItem().ToString();
		Destroy (this.gameObject);
	}

	void OnCollisionEnter (Collision collision) {
		if (this.gameObject.tag == "Car") {
			pc.chengePoint(-3);
			pc.lostItem ();
			rb.AddForce (collision.transform.up * -speedRate);
		}
	}

	void setRateByPoint() {
		for (int i = 0; i <= 50; i += 5) {
			if (pc.getPoint() == i) {
				j++;
				pc.setRate(j);
				break;
			}
		}
	}

}
