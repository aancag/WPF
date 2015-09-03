using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public class Startup
    {
        public Startup() {
            var mine = new List<RoleModel>();
            mine.Add(new RoleModel { Id = 0, Name = "anca"});
            mine.Add(new RoleModel { Id = 1, Name = "test1" });
            mine.Add(new RoleModel { Id = 2, Name = "test2" });
            mine.Add(new RoleModel { Id = 3, Name = "test3" });

            RoleViewModel roleViewModel = new RoleViewModel(mine);
            var main = new MainWindow();
            main.DataContext = roleViewModel;
            main.ShowDialog();
            var test = roleViewModel.selectedRoles;
        }
    }
}
