using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    [Serializable]
    public class SaveFileData
    {
        public bool canEnterLevel2 { get; set; }
        public bool canEnterLevel3 { get; set; }
        public bool canEnterLevel4 { get; set; }
        public bool canEnterLevel5 { get; set; }
        public bool canEnterLevel6 { get; set; }
        public ChooseLevel oldChooseLevel { get; set; }

        public void SetSave() {
            canEnterLevel2 = ChooseLevel.canEnterLevel2;
            canEnterLevel3 = ChooseLevel.canEnterLevel3;
            canEnterLevel4 = ChooseLevel.canEnterLevel4;
            canEnterLevel5 = ChooseLevel.canEnterLevel5;
            canEnterLevel6 = ChooseLevel.canEnterLevel6;
            oldChooseLevel = (ChooseLevel) StartManu.oldChooseLevel;

        }
        public void GetSave()
        {
            ChooseLevel.canEnterLevel2 = canEnterLevel2;
            ChooseLevel.canEnterLevel3 = canEnterLevel3;
            ChooseLevel.canEnterLevel4 = canEnterLevel4;
            ChooseLevel.canEnterLevel5 = canEnterLevel5;
            ChooseLevel.canEnterLevel6 = canEnterLevel6;
            StartManu.oldChooseLevel = oldChooseLevel;
        }


    }
}
