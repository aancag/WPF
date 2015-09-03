using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FirstWPF
{
    public class RoleViewModel
    {
        public List<RoleModel> roles { get; set; }
        public List<int> selectedRoles{get; set;}
        private bool _canExecute;
        
        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => MyAction(), _canExecute));
            }
        }
        
        public RoleViewModel(List<RoleModel> roles)
        {
            this.roles = roles;
            _canExecute = true;
        }
        
        
        public void MyAction()
        {
            selectedRoles = new List<int>();
            foreach (var role in roles) {
                if (role.IsChecked == true) {
                    selectedRoles.Add(role.Id);
                }
            }
            Application.Current.MainWindow.Close();

        }


    }
}
