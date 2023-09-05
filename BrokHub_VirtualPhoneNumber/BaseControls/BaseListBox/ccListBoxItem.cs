
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BrokHub_VirtualPhoneNumber.BaseControls.BaseListBox
{
    public enum Style
    {
        Style1,
        Style2,
    }


    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokHub_VirtualPhoneNumber.BaseControls.BaseListBox"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokHub_VirtualPhoneNumber.BaseControls.BaseListBox;assembly=BrokHub_VirtualPhoneNumber.BaseControls.BaseListBox"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ccListBoxItem/>
    ///
    /// </summary>
    public class ccListBoxItem : ListBoxItem
    {
        static ccListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccListBoxItem), new FrameworkPropertyMetadata(typeof(ccListBoxItem)));
        }

        public Style Styles
        {
            get { return (Style)GetValue(StylesProperty); }
            set { SetValue(StylesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Styles.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StylesProperty =
            DependencyProperty.Register("Styles", typeof(Style), typeof(ccListBoxItem), new PropertyMetadata(default));





        public PathGeometry Path
        {
            get { return (PathGeometry)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Pathcc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(PathGeometry), typeof(ccListBoxItem), new PropertyMetadata(default));

            

    }
}
