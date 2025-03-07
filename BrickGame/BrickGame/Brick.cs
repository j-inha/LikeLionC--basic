using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Brick
    {
        public BRICKDATA[] tBlock = new BRICKDATA[50];

        public Brick()
        {
            for(int i = 0; i < tBlock.Length; i++)
            {
                tBlock[i] = new BRICKDATA();
                tBlock[i].nX = 0;
                tBlock[i].nY = 0;
                tBlock[i].nLife = 0;
            }
        }

        //public void Create()
        //{
        //    Random rand = new Random();
            
        //}
        //public void DrawBrick()
        //{

        //}

    }
}
