using System;
using System.Collections;
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

namespace Calculating
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Stack myStack = new Stack();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtContents.Text != "")
            {
                string text = txtContents.Text;
                
                Calculating(inToPostfix(text));
            }
            else {
                MessageBox.Show("沒有資料");
            }
            
        }
        public void Calculating(string[] text)
        {
            
            /*string toDisplay = string.Join(Environment.NewLine, text);
            MessageBox.Show(toDisplay);*/
            int i =0;
            int ans=0;
            Boolean start = true;
            while (i<=text.Length-1 && text[i]!= null)
            {
                while(start == true)
                {
                    try
                    {
                        int var = Convert.ToInt32(text[i]);
                        start = true;
                    }
                    catch
                    {
                        break;
                    }
                    myStack.Push(text[i]);
                    i++;
                }

                string a = myStack.Pop().ToString();
                string b = myStack.Pop().ToString();
                switch (text[i])
                {
                    case "+": ans = int.Parse(b) + int.Parse(a);
                        break;
                    case "-": ans = int.Parse(b) - int.Parse(a);
                        break;
                    case "*": ans = int.Parse(b) * int.Parse(a);
                        break;
                    case "/": ans = int.Parse(b) / int.Parse(a);
                        break;
                }
                myStack.Push(ans);
                i++;
            }
            MessageBox.Show(Convert.ToString(ans));
        }
        public string[] inToPostfix(string text){
            string[] postfix = new string[text.Length];
            string[] chart = new string[text.Length];
            int i = 0;
            int j = -1;
            string x;
            for(i=0;i<=text.Length-1;i++){
                chart[i] = text[i].ToString();
            }
            for (i = 0; i <= text.Length - 1; i++)
            {
                x = chart[i];
                switch (chart[i])
                {
                    case "(":
                        myStack.Push(chart[i]);
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                       while ((myStack.Count != 0) && (priority(myStack.Peek().ToString()) >= priority(chart[i])))
                        {
                            postfix[++j] = myStack.Pop().ToString();
                        }
                       myStack.Push(chart[i]);
                        break;
                    case ")":
                        while ((myStack.Count != 0) && ((x = (myStack.Pop().ToString())) != "("))
                            postfix[++j] = x;
                        break;
                    default:
                        postfix[++j] = x;
                        break;
                }
            }
            while (myStack.Count != 0)
                postfix[++j] = myStack.Pop().ToString();

            return postfix;
        }
        public int priority(string op)
        {
            int i;
            switch (op)
            {
                case "+":case "-":
                    i = 1;
                    break;
                case "*":case "/":
                    i = 2;
                    break;
                default:
                    i = 0;
                    break;
            }
            return i;
        }
    }
}