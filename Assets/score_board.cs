using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_board : MonoBehaviour
{
    // Start is called before the first frame update
    public Text t;
    public int score;
    // Update is called once per frame
    void Update()
    {
        t.text = "Score: "+score.ToString();
    }
}
