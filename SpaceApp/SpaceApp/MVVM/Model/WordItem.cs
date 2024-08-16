using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpaceApp.MVVM.Model
{
    public class WordItem
    {
        public string Text { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
