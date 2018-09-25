using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayControl : MonoBehaviour {
    public tDAry[] pubAry = new tDAry[9];
    public static tDAry[] ary;

    public BtAry[] bts = new BtAry[9];
    GameObject solver;

	// Use this for initialization of the sudoku array
	void Awake () {
        ary = pubAry;
        solver = GameObject.FindGameObjectWithTag("solver");
        //if ary premade, load ary into button
        //also check slover first to see if the puzzle is valid
        if (ary[0]!=ary[1] && solver.GetComponent<Solver>().solvable())
        {
            int k = 0;
            Debug.Log("Beep");
            for (int i = 0; i < 9; i++)
            {

                for(int j = 0; j < 9; j++)
                {
                    GameObject bt = GameObject.
                        FindGameObjectWithTag("NumBt"+i);
                        bts[i].bts[j] = bt;
                    /*if (pubAry[i].aryD1[j] != 0)
                    {
                        bt.GetComponentInChildren<Text>().text
                            = pubAry[i].aryD1[j] + "";
                    }
                    else
                    {
                        bt.GetComponentInChildren<Text>().text = "";
                    }*/

                }
                //after finish going through 1 array, sort it
                bts[i] = arraySorting(bts[i]);
            }

            
        }
        //else, create new sudoku puzzle
        else
        {

        }
	}
	
    public BtAry arraySorting(BtAry bts)
    {
        BtAry res = new BtAry();

        return res;
    }
}

[System.Serializable]
public class tDAry
{
    public int[] aryD1 = new int[9];

    public tDAry(int count, int num)
    {
        aryD1[count] = num;
    }
}

[System.Serializable]
public class BtAry
{
    public GameObject[] bts;
}
