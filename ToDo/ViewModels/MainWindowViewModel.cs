using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using ToDo.Common.Models;

namespace ToDo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenu();
        }

        #region Commands
        
        #endregion

        #region Properties
        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }



        #endregion

        #region Methods
        private void CreateMenu()
        {
            MenuBars.Add(new MenuBar { Icon = "HomeVariant", Title = "首页", NameSpace = "" });
            MenuBars.Add(new MenuBar { Icon = "BookEdit", Title = "代办事件", NameSpace = "" });
            MenuBars.Add(new MenuBar { Icon = "CalendarText", Title = "备忘录", NameSpace = "" });
            MenuBars.Add(new MenuBar { Icon = "CogOutline", Title = "设置", NameSpace = "" });

        }
        #endregion
    }
}
