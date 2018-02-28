using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using Microsoft.Win32;

namespace TestingWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ToDoList: Добавить защиту от неправильного ввода, подгружение методов расчета, отображение прогресса рассчета
        public MainWindow()
        {
            InitializeComponent();
            SetF1CommandBinding();
        }
        private void SetF1CommandBinding()
        {
            CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);
            helpBinding.CanExecute += CanHelpExecute;
            helpBinding.Executed += HelpExecuted;
            CommandBindings.Add(helpBinding);
        }
        private void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }
        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e) {
            MessageBox.Show("Данная программа предназначена для нахождения кратчайшего пути" +
            " между множеством точек обладающих парой координат. Точки можно \n" +
            "либо задавать вручную в  верней таблице, \n" +
            "либо загрузить из файла установленного формата, \n" +
            "либо задать несколько случайных точек, \nвыбрав соответствующий пункт в меню.\n" +
            "Чтобы произвести рассчет кратчайшего маршрута необходимо выбрать соответствующий пункт в выпадающем меню."); }


        protected void OnWindowLoad(object sender, RoutedEventArgs args)
        {
            RefrashInitialData();
            RefrashResults();
        }
        private void RefrashInitialData()
        {
            initialData.ItemsSource = locationsList;
            initialData.Columns[0].Header = "Название локации";
            initialData.Columns[0].Width = new DataGridLength(200, DataGridLengthUnitType.Star);
            initialData.Columns[1].Header = "Координата локации X";
            initialData.Columns[1].Width = new DataGridLength(75, DataGridLengthUnitType.Star);
            initialData.Columns[2].Header = "Координата локации Y";
            initialData.Columns[2].Width = new DataGridLength(75, DataGridLengthUnitType.Star);
            initialData.Columns[3].Visibility = Visibility.Collapsed;
        }
        private void RefrashResults()
        {
            results.ItemsSource = solution;
            results.Columns[0].Header = "Расстояние до предыдущей локации";
            results.Columns[0].Width = new DataGridLength(75, DataGridLengthUnitType.Star);
            results.Columns[1].Header = "Название локации";
            results.Columns[1].Width = new DataGridLength(200, DataGridLengthUnitType.Star);
            results.Columns[2].Header = "Координата локации X";
            results.Columns[2].Width = new DataGridLength(75, DataGridLengthUnitType.Star);
            results.Columns[3].Header = "Координата локации Y";
            results.Columns[3].Width = new DataGridLength(75, DataGridLengthUnitType.Star);
            results.Columns[4].Visibility = Visibility.Collapsed;
        }

        List<Location> locationsList = new List<Location>();
        List<TestingWPF.SolutionMetods.TravellingSalesmanProblem.Solution> solution =
            new List<SolutionMetods.TravellingSalesmanProblem.Solution>();
        string method = "any";

        protected void MouseEnterInitialData(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Нажмите на пустую ячейку, чтобы добавить локацию, или на заполненную, чтобы изменить данные.";
        }
        protected void MouseDoubleClickInitialData(object sender, RoutedEventArgs args)
        {
            if (initialData.SelectedItem == null) locationsList.Add(new Location());
        }
        protected void FileExitClick(object sender, RoutedEventArgs args)
        {
            this.Close();
        }
        protected void MouseEnterExit(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Выйти из приложения.";
        }
        new protected void MouseLeave(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Готово к выполнению. Нажмите F1 для вызова помощи.";
        }
        protected void MouseEnterRandom(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Добавить случайные точки.";
        }
        protected void FileRandomClick(object sender, RoutedEventArgs args)
        {
            if (Convert.ToInt32(RandomDotsToAdd.Text) > 0)
            {
                for (int i=0; i< Convert.ToInt32(RandomDotsToAdd.Text); i++)
                {
                    locationsList.Add(new Location(locationsList.Count + 1));
                }
                initialData.Items.Refresh();
            }
            else statusBarText.Text = "Пожалуйста, укажите количество точек, которые следует добавить, в виде целого числа превосходящего ноль.";
        }
        protected void MouseEnterExecute(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Рассчитать кратчайший маршрут.";
        }
        protected void FileExecuteClick(object sender, RoutedEventArgs args)
        {
            RepetitionCheck();
            if (locationsList.Count >= 2)
            {
                TestingWPF.SolutionMetods.TravellingSalesmanProblem problem = new SolutionMetods.TravellingSalesmanProblem(locationsList, method);
                solution = problem.ToList();
                RefrashResults();
            }
        }
        private void RepetitionCheck()
        {
            if (locationsList.Count >= 2)
            {
                int border = locationsList.Count;
                for (int i = 0; i < border - 1; i++)
                {
                    for (int j = i + 1; j < border; i++)
                    {
                        if (locationsList[i] == locationsList[j])
                        {
                            locationsList.Remove(locationsList[j]);
                            border--;
                        }
                        if (i + 1 == border) break;
                    }
                }
            }
        }
        protected void MouseEnterMethod(object sender, RoutedEventArgs args)
        {
            statusBarText.Text = "Выбрать метод расчета кратчайшего маршрута.";
        }
        protected void FileMethodNearestNeighbourClick(object sender, RoutedEventArgs args)
        {
            method = "NearestNeighbour";
        }
        protected void FileMethodBruteforceClick(object sender, RoutedEventArgs args)
        {
            method = "Bruteforce";
        }
        private void OpenCommandCanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }
        private void SaveCommandCanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }
        private void OpenCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog { Filter = "Text Files |*.map" };
            if (true == openDialog.ShowDialog())
            {
                string dataFromFile = File.ReadAllText(openDialog.FileName);
                locationsList = new List<Location>();
                int locationIndex = 0;
                foreach (string loadedLocations in dataFromFile.Split('\n'))
                {
                    if (loadedLocations.Length > 0)
                    { 
                        int elementIndex = 0;
                        locationsList.Add(new Location());
                        foreach (string locationElement in loadedLocations.Split(' '))
                        {
                            switch(elementIndex)
                            {
                                case 0:
                                    locationsList[locationIndex].Name = locationElement;
                                    elementIndex++;
                                    break;
                                case 1:
                                    locationsList[locationIndex].X = Convert.ToDouble(locationElement);
                                    elementIndex++;
                                    break;
                                case 2:
                                    locationsList[locationIndex].Y = Convert.ToDouble(locationElement);
                                    break;
                            }
                        }
                        locationIndex++;
                    }
                }
                RefrashInitialData();
            }
        }
        private void SaveCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var saveDialog = new SaveFileDialog { Filter = "Text Files |*.map" };
            if (true == saveDialog.ShowDialog())
            {
                string dataToFile = "";
                for(int i = 0; i < locationsList.Count; i++)
                {
                    dataToFile += locationsList[i].Name + " " + locationsList[i].X.ToString() + " " + locationsList[i].Y.ToString() + "\n";
                }
                File.WriteAllText(saveDialog.FileName, dataToFile);
            }
        }
    }
}
