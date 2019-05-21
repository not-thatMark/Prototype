using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype
{
    public partial class YesNoControl : System.Web.UI.UserControl
    {

        public Label YesNoLabel
        {
            set { YesNoQuestion_Label = value; }
            get { return YesNoQuestion_Label; }
        }

        public RadioButtonList YesNoRadioButtonList
        {
            set { YesNo_Question_RadioButtonList = value;}
            get { return YesNo_Question_RadioButtonList; }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}