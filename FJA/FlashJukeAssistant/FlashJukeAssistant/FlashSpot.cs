using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashJukeAssistant
{
    public class FlashSpot
    {
        public Vector3 start;
        public Vector3 end;
        public Vector3 target;
        public FlashSpot(Vector3 Start, Vector3 Target, Vector3 End)
        {
            start = Start;
            end = End;
            target = Target;
        }
        private string vecConst(Vector3 v)
        {
            return "new Vector3(" + v.X + "f," + v.Y + "f," + v.Z + "f)";
        }
        public string getConstructor()
        {
            return ("new FlashSpot(" + vecConst(start) + "," + vecConst(target) + "," + vecConst(end) + ")");
        }
        
    }
}
