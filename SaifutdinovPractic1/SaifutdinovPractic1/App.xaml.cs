using SaifutdinovPractic1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace SaifutdinovPractic1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SaifutdinovWPFEntities DB = new SaifutdinovWPFEntities();
    }
}
