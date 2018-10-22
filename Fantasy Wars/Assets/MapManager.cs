using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    //マップタイルのプレハブを置く配列
    public GameObject[] Map = new GameObject[3];
    public GameObject Player;
    
    // マップデータ
    List<List<int>> _originalMapList;


    [SerializeField]
    Transform MapParent;

    public int[] PlayerPosition = {0,0};

    // マップの配置
    public int[,] MapTile = {
        {1,1,1,1,1,1},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
    };

    // Use this for initialization
    void Start() {
        

        //マップ生成
        for(int y = 0; y < 8; y++) {
            for(int x = 0; x < 6; x++) {    // 
                Instantiate(Map[MapTile[(MapTile.GetLength(0) - 1 - y), x]], new Vector3((x + 0.5f) * 80, (y + 1)* 80, 0.0f), Quaternion.identity, MapParent);

            }
        }
        Instantiate(Player,new Vector3(PlayerPosition[0], PlayerPosition[1],0),Quaternion.identity, MapParent);
    }


	// Update is called once per frame
	void Update () {
		
	}
}
