using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy_Vision
{
    class PolygonConstants
    {
        //--------------------------------
        public int circleDetail = 40; //20 vertices
        public int lineDetail = 20; //30 checks for collision per line
        //--------------------------------
        public float alfa;
        public float[] sinTable;
        public float[] cosTable;
        public System.Drawing.Color color;
        public PolygonConstants()
        {
            alfa = (float)(2 * Math.PI / circleDetail);
            sinTable = new float[circleDetail];
            cosTable = new float[circleDetail]; 
            double currentAlfa = -alfa;
            for (int i = 0; i < circleDetail; i++)
            {
                currentAlfa += alfa;
                sinTable[i] = (float)Math.Sin(currentAlfa);
                cosTable[i] = (float)Math.Cos(currentAlfa);
            }
        }
    }
}
