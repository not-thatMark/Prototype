using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype
{
    public partial class MultipleChoicesControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public Label QuestionLabel {

            set { MultipleChoices_Question_Label = value;}
            get { return MultipleChoices_Question_Label; }
        }
        public CheckBoxList QuestionCheckBoxList {
            set { MultipleChoices_Question_CheckBoxList = value; }
            get { return MultipleChoices_Question_CheckBoxList; }
        }

        }
}