using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_project.POM.SwagLabs.AccountLogin
{
     public partial class LoginPage : BasePage
    {
        public string username { get; set; }
        public string password { get; set; }


        public void Login() {
            if (username != null)
            {
                EnterText(txtUsername, username);
            }
            if(password != null) {

                EnterText(txtPassword,password);
            
            }
            Click(login_btn);
        
        }

    }

  
}
