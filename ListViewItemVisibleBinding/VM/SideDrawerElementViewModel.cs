using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ListViewItemVisibleBinding.VM
{
    class SideDrawerElementViewModel: ViewModelBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        private string _glyph;
        public string Glyph
        {
            get => _glyph;
            set => Set(ref _glyph, value);
        }

        private Visibility _itemvisibility;
        public Visibility ItemVisibility
        {
            get => _itemvisibility;
            set => Set(ref _itemvisibility, value);
        }
        public string sIV
        { get => ItemVisibility.ToString(); }

        public SideDrawerElementViewModel(string content, string glyph, Visibility visibility)
        {
            Text = content;
            Glyph = glyph;
            ItemVisibility = visibility;
        }
    }
}
