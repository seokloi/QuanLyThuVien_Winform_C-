using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SETTING
    {
        private int _ID;
        private string _NAMESETTING;
        private string _VALUESETTING;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public string NAMESETTING
        {
            get
            {
                return _NAMESETTING;
            }
            set
            {
                _NAMESETTING = value;
            }
        }
        public string VALUESETTING
        {
            get
            {
                return _VALUESETTING;
            }
            set
            {
                _VALUESETTING = value;
            }
        }
        public DTO_SETTING()
        {

        }
        public DTO_SETTING(int id, string nameSetting, string valueSetting)
        {
            this.ID = id;
            this.NAMESETTING = nameSetting;
            this.VALUESETTING = valueSetting;
        }
    }
}
