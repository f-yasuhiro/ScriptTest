using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	//変数mpの宣言
	private int mp = 53;

	//mpを消費して魔法攻撃をするMagic関数
	public void Magic(){
		if (mp >= 5) {
			//mpが5以上の場合
			this.mp -= 5;		//mpを5消費
			Debug.Log ("魔法攻撃をした。残りMPは" + mp +"。");
		} else {
			//mpが5未満の場合
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//Lesson4の課題のコード

		//配列の初期化
		int[] array = {2, 4, 7, 9, 10};

		//配列の各要素を順に表示
		Debug.Log ("順に表示");
		for (int i = 0; i < array.Length; i++) {
			Debug.Log ("array[" + i + "] = " + array [i]);
		}
		//配列の各要素を逆順に表示
		Debug.Log ("逆順に表示");
		for (int i = 1; i <= array.Length; i++) {
			Debug.Log ("array[" + (array.Length-i) + "] = " + array [array.Length-i]);
		}
		Debug.Log ("");


		//発展課題のコード
		Debug.Log ("以下が発展課題の出力。");

		//Bossクラスのインスタンスを生成
		Boss lastboss = new Boss ();

		//Magic関数を10回使用
		for (int i = 0; i < 10; i++) {
			lastboss.Magic ();
		}
		//更にMagic関数を使用
		lastboss.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
