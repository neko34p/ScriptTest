using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	int Magic (int mp) {
		if (mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
		return mp;
	}

	// Use this for initialization
	void Start () {
		// 課題
		int[] points = {1,3,5,7,9};
		for (int i = points.Length; i > 0; i--) {
			Debug.Log (points[i-1]);
		}

		// 発展問題
		int mp = 53;
		for (int i = 0; i < 11; i++) {
			mp = Magic (mp);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
