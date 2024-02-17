using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace battleship
{
    public class GameManager : MonoBehaviour

    {
        [SerializeField]

        [SerializeField] GameObject cellPrefab;
        [SerializeField] GameObject WinLabel;
        [SerializeField] TextMeshProUGI TimeLabel;
        [SerializeField] TextMeshProUGUI ScoreLabel;
            



        private int[,] grid = new int[,]
        {
            {1,1,0,0,1},
            {0,0,0,0,0},
            {0,0,1,0,1},
            {1,0,1,0,0},
            {1,0,1,0,1}

        };

        //Represents where the player has fired

        private bool[,] hits;


        //Total rows and columns we have
        private int nRows;
        private int nCols;

        //Current row/column we are on 
        private int[] row;
        private int[] col;

        //Correctly hit ships 
        private int score;

        //Total time game has been running 
        private int time;

        private void Awake()
        {

            nRows = grid.GetLength(0);
            nCols = grid.GetLength(1);

            hits = new bool[nRows, nCols];

            //Populate the grid using a loop
            //Needs to execute as many times to fill up the grid
            for(int i = 0; i < nRows*nCols; i++)
            {
                Instantiate (cellPrefab, gridRoot)

            };



        };



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }





    }
}