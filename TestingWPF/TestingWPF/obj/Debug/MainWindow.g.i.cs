#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FE2453445795E5678A1206A9FDCB0EAFFCDC972"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TestingWPF;


namespace TestingWPF
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RandomDotsToAdd;

#line default
#line hidden


#line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusBarText;

#line default
#line hidden


#line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;

#line default
#line hidden


#line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid initialData;

#line default
#line hidden


#line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid results;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestingWPF;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.window = ((TestingWPF.MainWindow)(target));

#line 9 "..\..\MainWindow.xaml"
                    this.window.Loaded += new System.Windows.RoutedEventHandler(this.OnWindowLoad);

#line default
#line hidden
                    return;
                case 2:

#line 14 "..\..\MainWindow.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenCommandExecuted);

#line default
#line hidden

#line 14 "..\..\MainWindow.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.OpenCommandCanExecute);

#line default
#line hidden
                    return;
                case 3:

#line 15 "..\..\MainWindow.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandExecuted);

#line default
#line hidden

#line 15 "..\..\MainWindow.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandCanExecute);

#line default
#line hidden
                    return;
                case 4:

#line 20 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterRandom);

#line default
#line hidden

#line 20 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);

#line default
#line hidden

#line 20 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FileRandomClick);

#line default
#line hidden
                    return;
                case 5:
                    this.RandomDotsToAdd = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:

#line 23 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterMethod);

#line default
#line hidden

#line 23 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);

#line default
#line hidden
                    return;
                case 7:

#line 24 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FileMethodNearestNeighbourClick);

#line default
#line hidden
                    return;
                case 8:

#line 25 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FileMethodBruteforceClick);

#line default
#line hidden
                    return;
                case 9:

#line 28 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterExecute);

#line default
#line hidden

#line 28 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);

#line default
#line hidden

#line 28 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FileExecuteClick);

#line default
#line hidden
                    return;
                case 10:

#line 32 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterExit);

#line default
#line hidden

#line 32 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);

#line default
#line hidden

#line 32 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FileExitClick);

#line default
#line hidden
                    return;
                case 11:
                    this.statusBarText = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 12:
                    this.mainGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 13:
                    this.initialData = ((System.Windows.Controls.DataGrid)(target));

#line 48 "..\..\MainWindow.xaml"
                    this.initialData.Loaded += new System.Windows.RoutedEventHandler(this.AddEmptyRowToInitialData);

#line default
#line hidden

#line 49 "..\..\MainWindow.xaml"
                    this.initialData.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterInitialData);

#line default
#line hidden

#line 49 "..\..\MainWindow.xaml"
                    this.initialData.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MouseDoubleClickInitialData);

#line default
#line hidden

#line 49 "..\..\MainWindow.xaml"
                    this.initialData.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);

#line default
#line hidden
                    return;
                case 14:
                    this.results = ((System.Windows.Controls.DataGrid)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window window;
    }
}

