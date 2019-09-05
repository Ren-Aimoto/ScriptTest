using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;    //体力
	private int power = 25; //攻撃力
	private int mp = 53; //マジックポイント
	//攻撃用の関数
	public void Attack() {
		Debug.Log (this.power+ "のダメージを与えた");
	}
	public void Defense(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		//n残りHPを減らす
		this.hp -= damage;
	}
		public void Magic () {
		this.mp -= 5;
			if (this.mp >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
	}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

			int[] array = new int[6];
			array [0] = 0;
			array [1] = 1;
			array [2] = 2;
			array [3] = 3;
			array [4] = 4;
			array [5] = 5;

			for (int i = 0; i <= 5; i++) {
				Debug.Log (array [i]);
			}

			for (int i = 5; i > 0; i--) {
				Debug.Log (array [i]);
			}
		Boss lastboss = new Boss ();
		lastboss.Attack ();
		lastboss.Defense(3);
		//魔法の関数を呼び出す
		lastboss.Magic ();
		//魔法関数を10回使用し、mpを足りなくする。
		for (int i = 0; i<10; i++){
				lastboss.Magic();
			}
	}
	// Update is called once per frame
	void Update () {			
	    }
	}