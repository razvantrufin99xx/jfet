/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jfet
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public class jfet
		{
			public double ID;
			public double UD;
			public double RD;
			
			public double IG;
			public double UG;
			public double RG;
			
			
			public double IS;
			public double US;
			public double RS;
			
			public double VGG;
			public double VDD;
			public double VGS;
			public double VGD;
			public double IDSS;
			public double VDS;
			
			public double VGSBlocare;
			public double VStrapungere;
			public double VStrangulare; //Vp
			public double VGSblocare;
			
			//A zero
			public bool isInPointA()
			{
				if(this.ID == 0 && this.VDS==0){ return true;}
				else {return false;}
			}
			//B IDSS si Vp vstrangulare
			public bool isInPointB()
			{
				if(this.ID == this.IDSS && this.VDS==this.VStrangulare){ return true;}
				else {return false;}
			}
			//regiunea ohmica AB
			public bool isInRegiuneaOhmicaAB()
			{
				if(this.ID < this.IDSS && this.VDS< this.VStrangulare){ return true;}
				else {return false;}
			}
			//C
			public bool isInPointC()
			{
				if(this.ID >= this.IDSS && this.VDS==this.VStrapungere){ return true;}
				else {return false;}
			}
			//regiunea de curent constant BC
			public bool isInRegiuneaDeCurentConstantBC()
			{
				if(this.ID < this.IDSS && this.VDS< this.VStrangulare){ return true;}
				else {return false;}
			}
			//regiunea de curent strapungere C++
			public bool isInRegiuneaDeStrapungereCpp()
			{
				if(this.ID > this.IDSS && this.VDS> this.VStrapungere){ return true;}
				else {return false;}
			}
			//regiunea de blocare
			public bool isBlocat()
			{
				if(this.VGS < this.VGSblocare){return true;}
				else {return false;}
			}
			//is at IDSS at VGS=0
			public bool isAtIDSS()
			{
				if(this.ID == this.IDSS && this.VGS == 0){return true;}
				else {return false;}
			}
			
			
			public jfet(){}
			public void jfetDetValMinimVDDptalucrainregimdecurentconstant(double pvgsblocare = -4,double pidss = 12, double pvgslaidss = 0, double prd=560 )
			{
				double xvp = pvgsblocare*(-1);
				double xvds = pvgsblocare*(-1);
				double xvrd = pidss*prd;
				double xvdd = xvds + xvrd;
				
			}
			
			public void  IDcaracteristicatransfer(double pidss, double pvgs, double pvgsblocare)
			{
				double xidss = pidss*Math.Pow((1-(pvgs/pvgsblocare)),2);
			}
			
			public double deltaXabs(double a, double b)
			{
				return Math.Abs(b-a);
			}
			public double deltaX(double a, double b)
			{
				return b-a;
			}
			public void gmTransconductantaDirectaJfet(double pdeltaid, double pdeltavgs)
			{
				double xgm = pdeltaid / pdeltavgs;
			}
			//admitanta de transfer direct gfs si yfs
			public double yfs;
			public double yGS;
			
			public double Ciss;
			public double Crss;
			
			public double P0; 
			public double corectareP0la25gC;
			
			public double Tj;
			public double Tsigmin;
			public double tsigmax;
			
			public double IGSS;
			public double VGoff;
			
			public double gm0;
			public double gm;
			public void gmTransconductantaDirectaJfetgm0( double pvgsblocare,double pgm0)
			{
				double xgm = pgm0*Math.Pow((1-(pvgs/pvgsblocare)),2);
			}
			public void fgm0(double pidss, double pvgsblocare)
			{
				double xgm0 = (pidss*2)/(Math.Abs(pvgsblocare));
			}
			
			public double RIN;
			public void fRIN(double pvgs, double pigss)
			{
				double xrin = Math.Abs(pvgs/pigss);
			}
			
			public double r_ds;
			public void fr_ds(double deltavds, double deltaid)
			{
				double xr_ds = deltavds / deltaid;
			}
			
			//jfet polarzare automata
			
		
		
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
