using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speedRate;
	public float boostRate;
	public float breakRate;
	public float rotateRate;
	public int point = 0;
	public static string item = "";
	public Rigidbody rb;
	public GameObject playerPosition;

	public Animator anim;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		// 1人目
		if (Input.GetKeyDown (KeyCode.W)) {
			paddleRight (1.0f);
			anim.SetBool ("RowRight",true);
			anim.SetBool ("RowLeft", false);
		}
		else if (Input.GetKeyDown (KeyCode.Q)) {
			paddleLeft (1.0f);
			anim.SetBool ("RowLeft",true);
			anim.SetBool ("RowRight", false);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			breakRight (1.0f);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			breakLeft (1.0f);
		}
		// 2人目
		if (Input.GetKeyDown (KeyCode.F)) {
			paddleRight (1.1f);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			paddleLeft (1.1f);
		}
		if (Input.GetKeyDown (KeyCode.V)) {
			breakRight (1.1f);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			breakLeft (1.1f);
		}
		// 3人目
		if (Input.GetKeyDown (KeyCode.J)) {
			paddleRight (1.3f);
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			paddleLeft (1.3f);
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			breakRight (1.3f);
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			breakLeft (1.3f);
		}
		// 4人目
		if (Input.GetKeyDown (KeyCode.O)) {
			paddleRight (1.5f);
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			paddleLeft (1.5f);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			breakRight (1.5f);
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			breakLeft (1.5f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			useItem(rb);
		}

		playerPosition.transform.position = transform.position + Vector3.up * 100;
	}

	void useItem(Rigidbody rb) {
		if (getItem() == "Mushroom") {
			rb.AddForce (transform.up * boostRate);
		}
		item = "";
	}

	public int getPoint() {
		return point;
	}

	public static string getItem() {
		return item;
	}

	public static void setItem(string itemV) {
		item = itemV;
	}

	public void chengePoint(int pointValue) {
		point += pointValue;
	}

	public void lostItem() {
		item = "";
	}

	void paddleRight(float memberRate) {
		// 右加速
		rb.AddForce (transform.up * speedRate);
		rb.AddTorque (transform.forward * rotateRate * memberRate);
	}

	void paddleLeft(float memberRate) {
		// 左加速
		rb.AddForce (transform.up * speedRate);
		rb.AddTorque (transform.forward * -rotateRate * memberRate);
	}

	void breakRight(float memberRate) {
		// 右減速
		rb.AddForce (transform.up * -breakRate);
		rb.AddTorque (transform.forward * -rotateRate * memberRate);
	}

	void breakLeft(float memberRate) {
		// 左減速
		rb.AddForce (transform.up * -breakRate);
		rb.AddTorque (transform.forward * rotateRate * memberRate);
	}
	public void setRate(int rate) {
		speedRate += (rate * 100);
	}
}