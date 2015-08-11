using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Windows3_2
{
	public partial class Form1 : Form
	{
		int SW=0;

		public Form1()
		{
			InitializeComponent();

			Thread nonParameterThread = new Thread(new ParameterizedThreadStart(NonParameterRun));
			nonParameterThread.Start("");

		}

		public void NonParameterRun(object str)
		{
			while(true)
			{
				if (SW != this.Width) 
				{ 
					SW = this.Width;
					if (tabControl1.InvokeRequired)
					{
						Action<string> actionDelegate = (x) => 
							{ this.tabControl1.ItemSize = new Size((SW/4-6), 160); };
						this.tabControl1.Invoke(actionDelegate, str);
					}
					else
					{
						this.tabControl1.ItemSize = new Size((SW/4-6), 160);
					}
				}
/*				if (groupBox1.InvokeRequired)
				{
					Action<string> actionDelegate = (x) => 
						{ this.groupBox1.Text = "箱体状态:正常"; };
					this.groupBox1.Invoke(actionDelegate, str);
				}
				else
				{
					this.groupBox1.Text = "箱体状态:正常";
				}
				
			if (tabPage1.InvokeRequired)
			{
				Action<string> actionDelegate = (x) => 
					{ this.tabPage1.Text = "箱体"; };
				this.tabPage1.Invoke(actionDelegate, str);
			}
			else
			{
				this.tabPage1.Text = "箱体";
			}
			if (tabPage1.InvokeRequired)
			{
				Action<string> actionDelegate = (x) => 
					{ this.tabPage1.Text = "箱体"; };
				this.tabPage1.Invoke(actionDelegate, str);
			}
			else
			{
				this.tabPage1.Text = "箱体";
			}
*/
				if (label1.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{ this.label1.Text =	"整体框架结构：正常\n"	+	"轮        子：正常；正常；正常；正常\n"	+	"立        柱：正常；正常；正常；正常\n"	+	"窗 口 玻 璃 ：正常\n"; };
					this.label1.Invoke(actionDelegate, str);
				}
				else
				{
					this.label1.Text = "整体框架结构：正常\n" + "轮        子：正常；正常；正常；正常\n" + "立        柱：正常；正常；正常；正常\n" + "窗 口 玻 璃 ：正常\n"; 
				}
				if (label2.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label2.Text =	"电        机：正常\n" +	"开        关：正常\n" +	"电        压：正常 221.6V\n" +	"电        流：正常   0.2A\n";
					};
					this.label2.Invoke(actionDelegate, str);
				}
				else
				{
					this.label2.Text = "电        机：正常\n" + "开        关：正常\n" + "电        压：正常 221.6V\n" + "电        流：正常   0.2A\n";
				}
				if (label3.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label3.Text =	"步 进 电 机 ：X轴正常；Y轴正常；Z轴正常\n" +	"驱  动   板 ：正常\n" +	"电        压：正常 24.3V\n" +	"电        流：正常  0.2A\n" +	"限        位：正常  \n";
					};
					this.label3.Invoke(actionDelegate, str);
				}
				else
				{
					this.label3.Text = "步 进 电 机 ：X轴正常；Y轴正常；Z轴正常\n" + "驱  动   板 ：正常\n" + "电        压：正常 24.3V\n" + "电        流：正常  0.2A\n" + "限        位：正常  \n";
				}
				if (label4.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label4.Text = "管        道：正常\n" +	"阀        门：正常\n" +	"电        压：正常 24.2V\n" +	"电        流：正常  0.0A\n";
					};
					this.label4.Invoke(actionDelegate, str);
				}
				else
				{
					this.label4.Text = "管        道：正常\n" + "阀        门：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.0A\n";
				}

				if (label5.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label5.Text = "压        力：正常\n" + "阀        门：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.0A\n";
					};
					this.label5.Invoke(actionDelegate, str);
				}
				else
				{
					this.label5.Text = "压        力：正常\n" + "阀        门：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.0A\n";
				}
				if (label6.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label6.Text = "压        力：正常\n" + "电        压：正常 24.3V\n" + "电        流：正常  0.1A\n";
					};
					this.label6.Invoke(actionDelegate, str);
				}
				else
				{
					this.label6.Text = "压        力：正常\n" + "电        压：正常 24.3V\n" + "电        流：正常  0.1A\n";
				}
				if (label7.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label7.Text = "信        号：正常\n" +	"电        压：正常 24.2V\n" +	"电        流：正常  0.5A\n";
					};
					this.label7.Invoke(actionDelegate, str);
				}
				else
				{
					this.label7.Text = "信        号：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.5A\n";
				}
				if (label8.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label8.Text = "信        号：正常\n" + "电        压：正常 24.1V\n" + "电        流：正常  0.8A\n";
					};
					this.label8.Invoke(actionDelegate, str);
				}
				else
				{
					this.label8.Text = "信        号：正常\n" + "电        压：正常 24.1V\n" + "电        流：正常  0.8A\n";
				}

				if (label9.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label9.Text = "管        道：正常\n" + "阀        门：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.0A\n";
					};
					this.label9.Invoke(actionDelegate, str);
				}
				else
				{
					this.label9.Text = "管        道：正常\n" + "阀        门：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.0A\n";
				}
				if (label10.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label10.Text = "信        号：正常\n" + "电        压：正常 24.3V\n" + "电        流：正常  0.1A\n";
					};
					this.label10.Invoke(actionDelegate, str);
				}
				else
				{
					this.label10.Text = "信        号：正常\n" + "电        压：正常 24.3V\n" + "电        流：正常  0.1A\n";
				}
				if (label11.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label11.Text = "信        号：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.1A\n";
					};
					this.label11.Invoke(actionDelegate, str);
				}
				else
				{
					this.label11.Text = "信        号：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.1A\n";
				}
				if (label12.InvokeRequired)
				{
					Action<string> actionDelegate = (x) =>
					{
						this.label12.Text = "信        号：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.1A\n";
					};
					this.label12.Invoke(actionDelegate, str);
				}
				else
				{
					this.label12.Text = "信        号：正常\n" + "电        压：正常 24.2V\n" + "电        流：正常  0.1A\n";
				}
				Thread.Sleep(100);
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

	}
}
