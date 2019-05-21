using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype
{
    public partial class FillInTheBlankControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Label FillInQuestionLabel
        {
            set { FillInQuestionLabel = value; }
            get { return FillInQuestionLabel; }
        }
        public TextBox FillInQuestionTextBox
        {
            set { FillInQuestionTextBox = value; }
            get { return FillInQuestionTextBox; }
        }
       
    }
}