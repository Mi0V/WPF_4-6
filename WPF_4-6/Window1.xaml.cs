using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_4_6
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Phone> phones = new ObservableCollection<Phone>
        {
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990}
        };
        
        ObservableCollection<Tablet> Tablet = new ObservableCollection<Tablet>
        {
            new Tablet{Title ="Xiaomi tab", Os = "Android 13", Memory = 4, Screen = 10, Price = 27990},
            new Tablet{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 8, Screen = 8, Price = 67990},
            new Tablet{Title ="Xiaomi 13 Pro", Os = "Android 13", Memory = 6, Screen = 10, Price =47990},
            
        };
        
        ObservableCollection<Notebook> notebooks = new ObservableCollection<Notebook>
        {
            new Notebook{Title="Lenovo Legion Pro 7", Processor = "intel i9", RAM = 32, HDD = 512, VRAM = "RTX 3080", Screen = 16, Price = 178990},
            new Notebook{Title="ASUS ROG Zephyrus M16", Processor = "intel i9-13990H", RAM = 32, HDD = 512, VRAM = "RTX 3080", Screen = 16, Price = 228990},
            new Notebook{Title="MacBook Pro 16", Processor = "M2 Max", RAM = 32, HDD = 512, VRAM = "M2 Max", Screen = 16, Price = 178990},
            
        };

        public Window1()
        {
            InitializeComponent();
            phoneList.ItemsSource = phones;
            tabletsList.ItemsSource = Tablet;
            phonesGrid.ItemsSource = phones;
            
        }

        private void addTabBtn_Click(object sender, RoutedEventArgs e)
        {
            ListBox noteList = new ListBox();
            noteList.ItemsSource = notebooks;

            products.Items.Insert(products.Items.Count - 1, new TabItem
            {
                Header = new TextBlock { Text = tabNameTxt.Text },
                Content = noteList

            });
        }

        private void addNewPhone_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = new Phone();
            phones.Add(new Phone { Title = phoneName.Text, Os =phoneOS.Text, Memory = Convert.ToInt32(phoneMemory.Text), CameraRes = Convert.ToInt32(phoneCamera.Text), Price = Convert.ToInt32(phonePrice.Text)});
            
        }

        private void delButPhone_Click(object sender, RoutedEventArgs e)
        {
            phoneList.Items.Remove(phoneList.SelectedItem);            
        }
    }
}
