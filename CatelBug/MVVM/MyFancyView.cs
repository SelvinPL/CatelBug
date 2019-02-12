namespace CatelBug.MVVM
{
    using Catel.MVVM;
    using Catel.Windows.Controls;
    using System;
    using System.Diagnostics;
    using System.Windows.Media;

    public class MyFancyView : UserControl
    {
        public MyFancyView(IViewModel viewModel): base(viewModel)
        {
            //this is not working in 5.9 and working with 5.8
            Init();
        }

        public MyFancyView()
        {
            //this is not working in 5.9 and working with 5.8
            Init();
        }

        private void Init()
        {
            try
            {
                var grid = new System.Windows.Controls.Grid();
                grid.Background = Brushes.Red;
                AddChild(grid);
            } catch (Exception ex)
            {
                Console.WriteLine("==Exception in Init() {0}, trace: {1}==", ex.Message, ex.StackTrace);
                throw;
            }
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //this is working remove Init call from constructor
            //Init();
        }
    }
}
