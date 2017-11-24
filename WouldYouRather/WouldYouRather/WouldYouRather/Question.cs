using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WouldYouRather
{
    public class Question
    {
        private int _qID;
        private string _qC_1;
        private string _qC_2;
        private int _qA_1;
        private int _qA_2;

        public int qID { get => _qID; set => _qID = value; }
        public string qC_1 { get => _qC_1; set => _qC_1 = value; }
        public string qC_2 { get => _qC_2; set => _qC_2 = value; }
        public int qA_1 { get => _qA_1; set => _qA_1 = value; }
        public int qA_2 { get => _qA_2; set => _qA_2 = value; }

        public Question(int qID, string qC_1, string qC_2, int qA_1, int qA_2)
        {
            this.qID = qID;
            this.qC_1 = qC_1;
            this.qC_2 = qC_2;
            this.qA_1 = qA_1;
            this.qA_2 = qA_2;
        }
    }
}
