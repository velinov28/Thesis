using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thesis.Model;

namespace Thesis.Controller
{
    class LoginValidation
    {
        private string _username;
        private string _password;
        public string errText { get; private set; }
        private string addition = " При забравена парола - въведете потребителското си име " + 
            "в съответното поле и натиснете бутона Изпрати паролата ми по e-mail.";

        public LoginValidation(string username, string pass)
        {
            _username = username;
            _password = pass;
            errText = string.Empty;
        }

        public LoginValidation()
        {

        }

        bool IsEmpty(string s)
        {
            return s.Equals(string.Empty);
        }

        bool IsShorterThan(string s, int minlen)
        {
            if (s.Length < minlen)
                return true;
            else
                return false;
        }

        public bool ValidateUserInput(out Worker worker)
        {
            worker = null;
            if (IsEmpty(_username))
            {
                errText = "Потребителското име е празно.";
                return false;
            }

            if (IsEmpty(_password))
            {
                errText = "Паролата е празна." + addition;
                return false;
            }

            if (IsShorterThan(_username, 4))
            {
                errText = "Потребителското име е прекалено кратко.";
                return false;
            }

            if (IsShorterThan(_password, 4))
            {
                errText = "Паролата е прекалено кратка." + addition;
                return false;
            }

            Worker queryResult = WorkerData.IsUserLoginCorrect(_username, _password);

            if (queryResult == null)
            {
                errText = "Въвели сте грешно потребителско име или парола!" + addition;
                return false;
            }
            worker = queryResult;
            return true;
        }
    }
}
