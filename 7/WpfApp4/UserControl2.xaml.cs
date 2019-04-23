using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {

        public UserControl2()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SetTextProperty =
            DependencyProperty.Register("SetText", typeof(string), typeof(UserControl2), new
                PropertyMetadata("", new PropertyChangedCallback(OnSetTextChanged)));


        //2 - validatevaluecallback
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public static DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(UserControl2), null, new ValidateValueCallback(isNameValid));

        private static bool isNameValid(object value)
        {
            bool ret = true;
            string val = (string)value;

            if (!string.IsNullOrEmpty(val) &&
                System.Text.RegularExpressions.Regex.IsMatch(val, " [^a-z]+$"))
                ret = false;
            else
                ret = true;

            return ret;
        }

        //2 - coercevaluecallback
        /*
        public string Name2
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public static DependencyProperty NameProperty2 =
            DependencyProperty.Register("Name", typeof(string), typeof(UserControl2), null, new CoerceValueCallback(isNameValid));

        FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
        metadata.CoerceValueCallback = new CoerceValueCallback(CoerceMaximum);
        DependencyProperty.Register("Maximum", typeof(double),
        typeof(RangeBase), metadata);
        
        private static object CoerceMaximum(DependencyObject d, object value)
        {
            RangeBase basel = (RangeBase)d;
            if (((double)value) < basel.Minimum)
            {
                return basel.Minimum;
            }
            return value;
        }*/

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        private static void OnSetTextChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            UserControl2 UserControl2Control = d as UserControl2;
            UserControl2Control.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            txtbx1.Text = e.NewValue.ToString();
            MessageBox.Show(e.NewValue.ToString());
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name = txtbx1.Text;

            if (isNameValid(Name))
            {
                txtbx1.Text = "True";
            }
            else
            {
                txtbx1.Text = "False";
            }
        }

        //direct event
        private void Btn2_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("it's a direct event");
        }

        //bubblin event
        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("it's a bubbling event");
        }

        //tunel event
        private void Button_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("it's a tunnell event");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void txtbx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtbx1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        //tunneling
        //Опускаются по иерархии содержания. Они позволяют предварительно просматривать 
        //(и, возможно, останавливать) событие, прежде чем оно дойдет до подходящего элемента управления.
        //в следующем порядке будут вызываться
        //Image.MouseDown
        //StackPanel.MouseDown
        //Label.MouseDown


        //propdp
    }

    internal class HZ:DependencyObject
    {

        public string InnerText
        {
            get { return (string)GetValue(InnerTextProperty); }
            set { SetValue(InnerTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerTextProperty =
            DependencyProperty.Register("InnerText", typeof(string), typeof(UserControl2), new PropertyMetadata("DefaultInnerText"));
    }

    


}
