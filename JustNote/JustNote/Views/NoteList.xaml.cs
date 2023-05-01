using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JustNote
{
    public partial class NoteList : ContentPage
    {
        public NoteList()
        {
            InitializeComponent();
        }

        private void LifecycleEffect_Loaded(object sender, EventArgs e)
        {
            var edElem = sender as Editor;
            if (edElem != null) {
                edElem.Focus();
            }        
        }
    }
}