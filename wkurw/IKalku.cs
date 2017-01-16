using System;
using Android.Widget;

namespace wkurw
{
    interface IKalku
    {
        void zmien_znak(object sender, EventArgs e);
        void visible_of_first(object sender, CompoundButton.CheckedChangeEventArgs e);
        void visible_of_second(object sender, CompoundButton.CheckedChangeEventArgs e);
    }
}