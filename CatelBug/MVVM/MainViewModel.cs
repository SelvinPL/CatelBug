namespace CatelBug.MVVM
{
    using Catel.MVVM;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MainViewModel : ViewModelBase
    {

        public MyFancyViewModel FancyViewModel => new MyFancyViewModel();
    }
}
