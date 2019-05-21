using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

namespace Prototype
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public static string SESSION_QUESTION_No = "currentQuestionNumber";
        public static string SESSION_EXTRA_QUESTION = "ExtraQuestion";
        //get connection string
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }
        private int GetQuestionID()
        {


            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            SqlCommand currentQuestion = new SqlCommand("SELECT MIN(ID) FROM QUESTION", connection);
            int currentquestion = (int)currentQuestion.ExecuteScalar();
            //check the index of the current question 
            //whether its the first one 
            //if so load it id into the string
            //there is none of the question stored in the string
            if (HttpContext.Current.Session[SESSION_QUESTION_No] == null)
            {
                HttpContext.Current.Session[SESSION_QUESTION_No] = currentquestion;
            }
            //else get the current id
            else
            {
                currentquestion = (int)HttpContext.Current.Session[SESSION_QUESTION_No];
            }
            return currentquestion;
       
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int question = GetQuestionID();
            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            SqlCommand query=new SqlCommand("SELECT * FROM Question,QuestionType WHERE Question.TypeID=QuestionType.ID AND Question.ID=  "+question,connection);
            reader = query.ExecuteReader();
            //if the result is not empty
            if (reader.Read())
            {
                string content = (string)reader["Content"];
                int type = (int)reader["TypeID"];

                if (type.Equals(1))
                {//need to change the name of this file since yesno is not used
                    //but stull need this type for questionsc can only choose one option
                    YesNoControl yesnoquesiton = (YesNoControl)LoadControl("~/question_types_control/YesNoControl.ascx");
                    yesnoquesiton.ID = "1";
                    yesnoquesiton.YesNoLabel.Text = content;
                    
                    SqlCommand command = new SqlCommand("SELECT * FROM Option WHERE QuestionID= " + question, connection);
                    SqlDataReader yesnoreader = command.ExecuteReader();
                    while(yesnoreader.Read()){
                        ListItem item = new ListItem(yesnoreader["content"].ToString(), yesnoreader["id"].ToString());
                        yesnoquesiton.YesNoRadioButtonList.Items.Add(item);
                    }
                    quesitonPlaceHolder.Controls.Add(yesnoquesiton);
                }
                else if (type.Equals(2))
                {



                    MultipleChoicesControl mul = (MultipleChoicesControl)LoadControl("~/question_types_control/MultipleChoicesControl.ascx");
                    mul.ID = "2";
                    mul.QuestionLabel.Text = content;
                    SqlCommand command = new SqlCommand("SELECT * FROM Option WHERE QuestionID= " + question, connection);
                    SqlDataReader mulreader = command.ExecuteReader();

                    while (mulreader.Read())
                    {
                        ListItem item = new ListItem(mulreader["Content"].ToString(), mulreader["ID"].ToString());
                        mul.QuestionCheckBoxList.Items.Add(item);
                    }
                    quesitonPlaceHolder.Controls.Add(mul);
                }
                else
                {
                    FillInTheBlankControl fill = (FillInTheBlankControl)LoadControl("~/question_types_control/FillInTheBlankControl.ascx");
                    fill.ID = "3";
                    fill.FillInQuestionLabel.Text = content;
                    quesitonPlaceHolder.Controls.Add(fill);
                }
                

            }
        }

        protected void staffLoginButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            int getcurrentquestionid = GetQuestionID();
           
        }
    }
}