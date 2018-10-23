using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AttrOrderView : MonoBehaviour {

    [SerializeField] private AgentAttr agentAttr;

	// Use this for initialization
	void Start () {
        Debug.Log("Initialize Listener");
        agentAttr.AttrEvent.Subscribe(attrOrder =>
        {
            Debug.Log("Attribute:" + attrOrder.GetAttr() + "\n"
                + "Feel:" + attrOrder.GetFeel());

            // ex. 
            // Attr attr =  attrOrder.GetAttr();
            // if (attr == nowAttribute)      
            //  // do nothing //
            // else if (attr == Attr.SitDownOnTheChair)
            //   // -- some action -- //
            // else if (...)
            //  ...
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

// 10/24
// 今週の課題
// 課題1
// 　Robo Kyle を別のモデルに入れ替える
// 課題2
// 　Happy(喜んだ)表情の作成
// 　Awake(気づいた)表情の作成
// 課題3
// 　初期値として与えられるSitDownOntheChair(椅子の上に座る・座っている)アニメーションの作成
// 　WalkToGuest(カメラ方向に近づく)アニメーションの作成
// 　WaveHand(手を振る)アニメーションの作成
// 　Free(待機)アニメーションの作成
//
// 備考
//   最初に実行をしてデバッグログを確認すること
//   わからない部分はSlackなどを活用して共有すること
//   基本コードはすべてSimpleDemoScript以下に収めること
//   Agentのコードは作業に関係がないので弄らないこと
//   アニメーション関連のコードはAttribute 以下もしくは AgentAttr.cs Utils.cs 内に収めること
//   アニメーションは複数用意し、それらを組み合わせて良い(単一のアニメーションですべてを表現しようとするのは再利用性などの観点から推奨されない)
//
// 来週以降の方針
//   11月一杯まではモーションなどの作成に費やし、入力についてはW, A, S, Dのようなキーのみにする
//   実行時情報はDebug.Log関数を用いて表示していく