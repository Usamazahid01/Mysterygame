using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
	
	public partial class Form1 : Form
    {
		Stack stack1 = new Stack();
		Stack stack2 = new Stack();
		Stack stack3 = new Stack();
		Stack stackbig = new Stack();
		int count = 0;


		public Form1()
        {
            InitializeComponent();
        }
       
		private void button1_Click(object sender, EventArgs e)
        {
			//stack 2 poping
			count++;
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			//stack 1 poping
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			//stack 3 poping
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			/*foreach (var item in stackbig)
			{
				MessageBox.Show(Convert.ToString(item));
			}*/
			/////
			//string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21;
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());

			//a1.Text = Convert.ToString(stack1);
			//Application.Run(new Form2());
			int i = 1;
			foreach (var item in stack1)
			{
				
						if (i==1)
				{ 

                    a1.Text=(Convert.ToString(item));
				i++;
				}
				else if(i==2)
				{ 
						a2.Text=(Convert.ToString(item));
					i++;
				}
				else if(i==3)
				{ 
						a3.Text=(Convert.ToString(item));
					i++;
				}
				else if(i==4)
				{ 
						a4.Text=(Convert.ToString(item));
					i++;
				}
				else if(i==5)
				{ 
						a5.Text=(Convert.ToString(item));
					i++;
				}
				else if(i==6)
				{ 
						a6.Text=(Convert.ToString(item));
					i++;
				}
				else if(i==7)
				{ 
						a7.Text=(Convert.ToString(item));
					i++;
				}

			}
			

			int j = 1;
			foreach (var item in stack2)
			{

				if (j == 1)
				{

					a8.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 2)
				{
					a9.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 3)
				{
					a10.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 4)
				{
					a11.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 5)
				{
					a12.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 6)
				{
					a13.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 7)
				{
					a14.Text = (Convert.ToString(item));
					j++;
				}

			}

			int k = 1;
			foreach (var item in stack3)
			{

				if (k == 1)
				{

					a15.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 2)
				{
					a16.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 3)
				{
					a17.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 4)
				{
					a18.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 5)
				{
					a19.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 6)
				{
					a20.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 7)
				{
					a21.Text = (Convert.ToString(item));
					k++;
				}

			}
			checkcount(count);

		}

		private void startbutton_Click(object sender, EventArgs e)
        {
			
			
			/*foreach(var item in stack1)
            {
				MessageBox.Show(Convert.ToString(item));
			}
			foreach (var item in stack2)
			{
				MessageBox.Show(Convert.ToString(item));
			}
			foreach (var item in stack3)
			{
				MessageBox.Show(Convert.ToString(item));
			}*/
		}

        private void button2_Click(object sender, EventArgs e)
        {
			//stack 1 poping
			count++;
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			//stack 2 poping
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			//stack 3 poping
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			/*foreach (var item in stackbig)
			{
				MessageBox.Show(Convert.ToString(item));
			}*/
			/////
			//string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21;
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());

			//a1.Text = Convert.ToString(stack1);
			/*foreach (var item in stack1)
			{
				MessageBox.Show("satck 1");
				MessageBox.Show(Convert.ToString(item));
			}
			foreach (var item in stack2)
			{
				MessageBox.Show("satck 2");
				MessageBox.Show(Convert.ToString(item));

			}
			foreach (var item in stack3)
			{
				MessageBox.Show("satck 3");
				MessageBox.Show(Convert.ToString(item));

			}*/
			//Application.Run(new Form2());
			int i = 1;
			foreach (var item in stack1)
			{

				if (i == 1)
				{

					a1.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 2)
				{
					a2.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 3)
				{
					a3.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 4)
				{
					a4.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 5)
				{
					a5.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 6)
				{
					a6.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 7)
				{
					a7.Text = (Convert.ToString(item));
					i++;
				}

			}
			

			int j = 1;
			foreach (var item in stack2)
			{

				if (j == 1)
				{

					a8.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 2)
				{
					a9.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 3)
				{
					a10.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 4)
				{
					a11.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 5)
				{
					a12.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 6)
				{
					a13.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 7)
				{
					a14.Text = (Convert.ToString(item));
					j++;
				}

			}

			

			int k = 1;
			foreach (var item in stack3)
			{

				if (k == 1)
				{

					a15.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 2)
				{
					a16.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 3)
				{
					a17.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 4)
				{
					a18.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 5)
				{
					a19.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 6)
				{
					a20.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 7)
				{
					a21.Text = (Convert.ToString(item));
					k++;
				}

			}
			checkcount(count);
		}

        private void button3_Click(object sender, EventArgs e)
        {
			//stack 2 poping
			count++;
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			stackbig.Push(stack1.Pop());
			//stack 1 poping
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			stackbig.Push(stack3.Pop());
			//stack 3 poping
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			stackbig.Push(stack2.Pop());
			/*foreach (var item in stackbig)
			{
				MessageBox.Show(Convert.ToString(item));
			}*/
			/////
			//string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21;
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());
			stack1.Push(stackbig.Pop());
			stack2.Push(stackbig.Pop());
			stack3.Push(stackbig.Pop());

			//a1.Text = Convert.ToString(stack1);
			//Application.Run(new Form2());
			int i = 1;
			foreach (var item in stack1)
			{

				if (i == 1)
				{

					a1.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 2)
				{
					a2.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 3)
				{
					a3.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 4)
				{
					a4.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 5)
				{
					a5.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 6)
				{
					a6.Text = (Convert.ToString(item));
					i++;
				}
				else if (i == 7)
				{
					a7.Text = (Convert.ToString(item));
					i++;
				}

			}


			int j = 1;
			foreach (var item in stack2)
			{

				if (j == 1)
				{

					a8.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 2)
				{
					a9.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 3)
				{
					a10.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 4)
				{
					a11.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 5)
				{
					a12.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 6)
				{
					a13.Text = (Convert.ToString(item));
					j++;
				}
				else if (j == 7)
				{
					a14.Text = (Convert.ToString(item));
					j++;
				}

			}

			int k = 1;
			foreach (var item in stack3)
			{

				if (k == 1)
				{

					a15.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 2)
				{
					a16.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 3)
				{
					a17.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 4)
				{
					a18.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 5)
				{
					a19.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 6)
				{
					a20.Text = (Convert.ToString(item));
					k++;
				}
				else if (k == 7)
				{
					a21.Text = (Convert.ToString(item));
					k++;
				}

			}
			checkcount(count);
		}
		private void checkcount(int c)
		{
			//MessageBox.Show("Run");
			//MessageBox.Show(Convert.ToString(c));
			if (c == 3)
			{
				//MessageBox.Show("Runif");
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				stackbig.Push(stack1.Pop());
				//stack 1 poping
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				stackbig.Push(stack2.Pop());
				//stack 3 poping
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				stackbig.Push(stack3.Pop());
				int l = 1;
				foreach (var item in stackbig)
				{
					//if (stackbig.Count == 11)
					l++;
					if(l==12)
                    {
						Result.Text = (Convert.ToString(item));
					}
						//MessageBox.Show("Run innerif");
						
					
				}
				playagain.Visible = true;
				Note.Text = Convert.ToString("Note: If you want to play again click on button left bottom corner");
				button1.Visible = false; button2.Visible=false; button3.Visible=false;
			}
		}
			private void Form1_Load(object sender, EventArgs e)
        {
			stack1.Push(a1.Text);
			stack1.Push(a2.Text);
			stack1.Push(a3.Text);
			stack1.Push(a4.Text);
			stack1.Push(a5.Text);
			stack1.Push(a6.Text);
			stack1.Push(a7.Text);

			stack2.Push(a8.Text);
			stack2.Push(a9.Text);
			stack2.Push(a10.Text);
			stack2.Push(a11.Text);
			stack2.Push(a12.Text);
			stack2.Push(a13.Text);
			stack2.Push(a14.Text);

			stack3.Push(a15.Text);
			stack3.Push(a16.Text);
			stack3.Push(a17.Text);
			stack3.Push(a18.Text);
			stack3.Push(a19.Text);
			stack3.Push(a20.Text);
			stack3.Push(a21.Text);
		}

        private void button4_Click(object sender, EventArgs e)
        {
			Application.Restart();
		}

        private void button5_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}
    }
	

}