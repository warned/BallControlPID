using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CircleGame
{
    public partial class Form1 : Form
    {
        public struct Ball
        {
            public double[] fPos; 
            public double[] fVel;
            public double[] fAcc;
            public double fMass;
            public double fDiam;
            public double[,] stripeHi;
            public int[,] stripeH;
            public double[,] stripeVi;
            public int[,] stripeV;

            public Color cFill;
            public Color cOutline;
            //Constructor
            public Ball(double[] fPos, double[] fVel, double[] fAcc, double fMass, double fDiam, double[,] stripeHi, int[,] stripeH, double[,] stripeVi, int[,] stripeV, Color cFill, Color cOutline)
            {
                this.fPos = fPos;
                this.fVel = fVel;
                this.fAcc = fAcc;
                this.fMass = fMass;
                this.fDiam = fDiam;
                this.stripeHi = stripeHi;
                this.stripeH = stripeH;
                this.stripeVi = stripeVi;
                this.stripeV = stripeV;
                this.cFill = cFill;
                this.cOutline = cOutline;
            }
        }
        public struct Force
        {
            public double[] fTotal;
            public double[] fOP;
            public double[] fNoise;
            public double[] fFrict;
            public Force(double[] fTotal, double[] fOP, double[] fNoise, double[] fFrict)
            {
                this.fTotal = fTotal;
                this.fOP = fOP;
                this.fNoise = fNoise;
                this.fFrict = fFrict;
            }
        }
        public struct Control
        {
            public Boolean bSwtProp;  //Proportional Switch
            public Boolean bSwtInt;   //Integral Switch
            public Boolean bSwtDeriv; //Derivative Switch

            public double[] fIntError;
            public double[] fPosLast;
            public int[] iSP;

            public DateTime dPLastUpdate;
            public DateTime dVLastUpdate;

            public Control(Boolean bSwtProp, Boolean bSwtInt, Boolean bSwtDeriv, double[] fIntError, double[] fPosLast, int[] iSP, DateTime dPLastUpdate, DateTime dVLastUpdate)
            {
                this.bSwtProp = bSwtProp;
                this.bSwtInt = bSwtInt;
                this.bSwtDeriv = bSwtDeriv;
                this.fIntError = fIntError;
                this.fPosLast = fPosLast;
                this.iSP = iSP;
                this.dPLastUpdate = dPLastUpdate;
                this.dVLastUpdate = dPLastUpdate;
            }
        }
        public struct SysVars
        {
            public double fKp;
            public double fKi;
            public double fKd;
            public double fGravity;
            public double fFrict;
            public SysVars(double fKp, double fKi, double fKd, double fGravity, double fFrict)
            {
                this.fKp = fKp;
                this.fKi = fKi;
                this.fKd = fKd;
                this.fFrict = fFrict;
                this.fGravity = fGravity;
            }
        }
        public struct Point3D
        {
            public int one;
            public int two;
            public int three;
            public Point3D(int one, int two, int three)
            {
                this.one = one;
                this.two = two;
                this.three= three;
             }
        }

        public Ball myBall = new Ball();
        public Force myForce = new Force();
        public Control myControl = new Control();
        public SysVars mySysVars = new SysVars();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeStructs();
            AddColorsToCombo(cbColorFill);
            tmrDraw.Enabled = true;
            // Dock the PictureBox to the form and set its background to white.
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.Black;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen p = System.Drawing.Pens.Red;
            int x1, x2, y1, y2;
            SolidBrush b = new SolidBrush(Color.Red);
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            g.DrawEllipse(p, (int)((myBall.fPos[0]) + ((pictureBox1.Width - myBall.fDiam)/2)), (int)(-(myBall.fPos[1]) + ((pictureBox1.Height - myBall.fDiam)/2)), (int)myBall.fDiam, (int)myBall.fDiam);
            g.FillEllipse(b, (int)((myBall.fPos[0]) + ((pictureBox1.Width - myBall.fDiam)/2)), (int)(-(myBall.fPos[1]) + ((pictureBox1.Height - myBall.fDiam)/2)), (int)myBall.fDiam, (int)myBall.fDiam);

            p = System.Drawing.Pens.Blue;
            for (int i = 0; i<myBall.stripeH.GetLength(0);i++)
            {
                x1 = (int)(myBall.stripeH[i,0] + myBall.fPos[0] + (pictureBox1.Width / 2));
                x2 = x1;
                y1 = (int)(((-myBall.fPos[1]) + myBall.stripeH[i,1] + (pictureBox1.Height / 2)) - 4);
                y2 = (int)(((-myBall.fPos[1]) + myBall.stripeH[i,1]+(pictureBox1.Height / 2)) + 4);
                //g.DrawLine(p, x1,y1, x2, y2);// Horizontal
                y1 = (int)((myBall.stripeV[i,1] - myBall.fPos[1] + (pictureBox1.Height / 2)));
                y2 = y1;
                x1 = (int)(((myBall.fPos[0]) + myBall.stripeV[i,0] + (pictureBox1.Width / 2))-1);
                x2 = (int)(((myBall.fPos[0]) + myBall.stripeV[i, 0] + (pictureBox1.Width / 2))+1);
                //g.DrawLine(p, x1, y1, x2, y2);// Vertical
            }
        }

        
        private void UpdateForces()
        {
            if (mySysVars.fFrict != 0)
            {
                SetFrictionForce();
            }
            for (int i = 0; i < myBall.fVel.Length; i++)
            {
                myForce.fTotal[i] = myForce.fOP[i] + myForce.fFrict[i] + myForce.fNoise[i];
            }
        }
        private void SetFrictionForce()
        {
            for (int i = 0; i < myBall.fVel.Length; i++)
            {
                if (myBall.fVel[i] > 0)
                {
                    myForce.fFrict[i] = -(mySysVars.fFrict * mySysVars.fGravity * myBall.fMass);
                }
                else if (myBall.fVel[i] < 0)
                {
                    myForce.fFrict[i] = mySysVars.fFrict * mySysVars.fGravity * myBall.fMass;
                }
                if (myBall.fVel[i] >  -5 && myBall.fVel[i] < 5) 
                {
                        myForce.fFrict[i] = mySysVars.fFrict * mySysVars.fGravity * myBall.fMass;
                        if (Math.Abs(myForce.fFrict[i]) > Math.Abs(myForce.fOP[i] + myForce.fNoise[i]))
                        {
                            myForce.fFrict[i] = -myForce.fOP[i] + myForce.fNoise[i];
                            HaltBall(myBall, i);
                        }                        
                }
            }
        }
        private void HaltBall(Ball b, int iDimension)
        {
            b.fAcc[iDimension] = 0;
            b.fVel[iDimension] = 0;
        }
        
        // Start Update Ball Movement
        private void UpdateAcceleration()
        {
            //a = F/m
            myBall.fAcc[0] = myForce.fTotal[0]/ myBall.fMass;
            myBall.fAcc[1] = myForce.fTotal[1] / myBall.fMass;
        }
        private void UpdateVelocity()
        {
            double fmSElapsed;

            TimeSpan dTimeElapsed;
            if (myControl.dVLastUpdate != new DateTime())
            {
                dTimeElapsed = System.DateTime.Now.Subtract(myControl.dVLastUpdate);
                fmSElapsed = dTimeElapsed.Milliseconds + (dTimeElapsed.Seconds * 1000);
                myBall.fVel[0] += (fmSElapsed * myBall.fAcc[0])/1000;
                myBall.fVel[1] += (fmSElapsed * myBall.fAcc[1])/1000;
            }
            myControl.dVLastUpdate = System.DateTime.Now;
        }
        private void UpdatePosition()
        {
            double fmSElapsed;
            TimeSpan dTimeElapsed;

            if (myControl.dPLastUpdate != new DateTime())
            {
                dTimeElapsed = System.DateTime.Now.Subtract(myControl.dPLastUpdate);
                fmSElapsed = dTimeElapsed.Milliseconds + (dTimeElapsed.Seconds)*1000;
                myBall.fPos[0] += ((fmSElapsed * myBall.fVel[0]) / 1000)/10; // ÷ by 1000 for milliseconds, ÷ by 10 for scaling
                myBall.fPos[1] += ((fmSElapsed * myBall.fVel[1]) / 1000)/10; // ÷ by 1000 for milliseconds, ÷ by 10 for scaling
            }
            myControl.dPLastUpdate = System.DateTime.Now;
        }
        // End Update Ball Movement

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            UpdateForces();
            UpdateAcceleration();
            UpdateVelocity();
            UpdatePosition();
            UpdateStripes();
            UpdateLabels();
            pictureBox1.Invalidate();
            ControlBall();
        }

        private void ControlBall()
        {
            double[] fErrP = new double[2];
            double[] fErrI = new double[2];
            double[] fErrD = new double[2];
            double temp;

            fErrP[0] = 0;
            fErrP[1] = 0;
            if (cbProp.Checked)
            {
                fErrP[0] = GetProportionalError("X");
                fErrP[1] = GetProportionalError("Y");
            }

            fErrI[0] = 0;
            fErrI[1] = 0;
            if (cbInt.Checked)
            {
                fErrI[0] = GetIntError("X");
                fErrI[1] = GetIntError("Y");
            }

            fErrD[0] = 0;
            fErrD[1] = 0;
            if (cbDeriv.Checked)
            {
                fErrD[0] = GetDerivError("X");
                fErrD[1] = GetDerivError("Y");
            }

            temp = GetDerivError(""); // just so last val gets updates.
            if (cbDeriv.Checked || cbInt.Checked || cbProp.Checked)
            {
                myForce.fOP[0] = ((mySysVars.fKp * fErrP[0]) + (-mySysVars.fKi * fErrI[0]) + (mySysVars.fKd * fErrD[0]));
                myForce.fOP[1] = (mySysVars.fKp * fErrP[1]) + (-mySysVars.fKi * fErrI[1]) + (mySysVars.fKd * fErrD[1]);
            }

        }

        // Start Get Error
        private double GetProportionalError(string axis)
        {
            int i = new int();

            if (axis == "X") i = 0; else if (axis == "Y") i = 1;
            return myControl.iSP[i] - myBall.fPos[i];
        }
        private double GetIntError(string axis)
        {
            double fErr;
            int i = new int();

            fErr = 0;
            if (axis == "X") i = 0; else if (axis == "Y") i = 1;
            fErr = myControl.fIntError[i] + (myBall.fPos[i] - myControl.iSP[i]);
            myControl.fIntError[i] = myBall.fPos[i] - myControl.iSP[i];
            return fErr;
        }
        public double GetDerivError(string axis)
        {
            double fErr;
            double fDiff;
            int i = new int();

            fErr = 0;
            if (axis != "")
            {
                if (axis == "X") i = 0; else if (axis == "Y") i = 1;
                fDiff = myBall.fPos[i] - myControl.fPosLast[i];
                fErr = -(fDiff);
            }
            else
            {
                myControl.fPosLast[0] = myBall.fPos[0];
                myControl.fPosLast[1] = myBall.fPos[1];
            }
            return fErr;
        }
        // End Get Error

        // Start Initializing Structures
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeMyBall();
            InitializeMyForce();
        }
        private void InitializeStructs()
        {
            InitializeMyBall();
            InitializeMyForce();
            InitializeMyControl();
            InitializeMySysVars();
        }
        private void InitializeMyBall()
        {
            tmrDraw.Enabled = false;
            myBall.fPos = new double[2] {0,0};
            myBall.fVel = new double[2] {0,0};
            myBall.fAcc = new double[2] {0,0};
            myBall.fMass = Convert.ToDouble(tbMass.Text);
            myBall.fDiam = Convert.ToDouble(tbSize.Text);
            InitializeStripes();
            tmrDraw.Enabled = true;
        }
        private void InitializeStripes()
        {
            double r;
            double theta;
            double phi;

            double x;
            double y;
            double z;

            myBall.stripeHi = new double[Convert.ToInt16((myBall.fDiam * Math.PI)+.5), 3];
            myBall.stripeVi = new double[myBall.stripeHi.GetLength(0),3];

            r = myBall.fDiam / 2;

            // Horizontal stripe 
            theta = 0;
            phi = 0;
            for (int i = 0; i < myBall.stripeHi.GetLength(0); i++)
            {
                if (i > 0)
                {
                    phi = (Convert.ToDouble(i) / Convert.ToDouble(myBall.stripeHi.GetLength(0) - 1));
                    phi = Math.PI  * 2 * phi;
                }
                theta = 0;
                x = r * Math.Cos(phi);
                y = r * Math.Sin(phi) * Math.Sin(theta);
                z = r * Math.Sin(phi) * Math.Cos(theta);
                myBall.stripeHi[i, Convert.ToInt16(0)] = x;
                myBall.stripeHi[i, 1] = y;
                myBall.stripeHi[i, 2] = z;
                theta = Math.PI / 2;
                x = r * Math.Sin(phi) * Math.Cos(theta);
                y = r * Math.Cos(phi);
                z = r * Math.Sin(phi) * Math.Sin(theta);
                myBall.stripeVi[i, 0] = x;
                myBall.stripeVi[i, 1] = y;
                myBall.stripeVi[i, 2] = z;
            }
            UpdateStripes();
        }
        private void UpdateStripes()
        {
            double r = myBall.fDiam / 2;
            double dCircum;
            double dAngleY;
            double dAngleX;
            int iOffset;
            double dTheta;

            dCircum = myBall.fDiam * Math.PI;

            // horizontal movement
            dAngleY = ((myBall.fPos[1] % dCircum) / dCircum) * (2 * Math.PI);
            // Vertical movement
            dAngleX = ((myBall.fPos[0] % dCircum) / dCircum) * (2 * Math.PI);

            iOffset = 0;
            myBall.stripeH = new int[Convert.ToInt16(myBall.stripeHi.GetLength(0) / 2), 2];
            myBall.stripeV = new int[Convert.ToInt16(myBall.stripeVi.GetLength(0) / 2), 2];
            for (int i = 0; i < myBall.stripeHi.GetLength(0); i++)
            {
                dTheta = GetAngle(myBall.stripeHi[i,0],myBall.stripeHi[i,2],myBall.fDiam/2);
                if (Math.Abs(dTheta + dAngleY) < (Math.PI / 2))
                { 
                    dTheta = GetAngle(myBall.stripeHi[i, 1], myBall.stripeHi[i, 2], myBall.fDiam / 2);
                    if (Math.Abs(dTheta + dAngleX) < (Math.PI/2))
                    {
                        myBall.stripeH[iOffset, 1] = Convert.ToInt16(-myBall.stripeHi[i, 2] * Math.Sin(dAngleY));
                        myBall.stripeH[iOffset, 0] = Convert.ToInt16(myBall.stripeH[iOffset, 0] + myBall.stripeHi[i, 0]);
                        iOffset++;
                    }
                }
            }
            iOffset = 0;
            for (int i = 0; i < myBall.stripeVi.GetLength(0); i++)
            {
                if (Convert.ToInt16((myBall.stripeVi[i, 2] * Math.Cos(dAngleX)) + .5) > 0)
                {
                    myBall.stripeV[iOffset, 0] = Convert.ToInt16(myBall.stripeVi[i, 2] * Math.Sin(dAngleX));
                    myBall.stripeV[iOffset, 1] = Convert.ToInt16(myBall.stripeVi[i, 1]);
                    iOffset++;
                }
            }
        }
        //Returns the an angle A such that -Pi<A<Pi, with respect to +Y axis
        private double GetAngle(double x, double y, double dH)
        {
            //Axis
            if (x > 0 && y == 0) return Math.PI/2; //+X axis
            if (x == 0 && y > 0) return 0; //+Y axis
            if (x < 0 && y == 0) return Math.PI / 2; //-X axis
            if (x == 0 && y < 0) return Math.PI; //-Y axis

            //In Between
            if (x > 0 && y > 0) return Math.Asin(x / dH); //1st Quad
            if (x < 0 && y > 0) return -Math.Asin(x / dH); //2nd Quad
            if (x < 0 && y < 0) return -((Math.PI)+Math.Asin(x / dH)); //3rd Quad
            if (x > 0 && y < 0) return Math.PI+Math.Asin(x / dH); //4th Quad

            return 404; //error
        }
        private void InitializeMyForce()
        {
            tmrDraw.Enabled = false;
            myForce.fTotal = new double[2] {0,0};
            myForce.fOP = new double[2] {0,0};
            myForce.fNoise = new double[2] {0,0};
            myForce.fFrict = new double[2] {0,0};
            tmrDraw.Enabled = true;
        }
        private void InitializeMyControl()
        {
            myControl.bSwtProp = cbProp.Checked;
            myControl.bSwtInt = cbInt.Checked;
            myControl.bSwtDeriv = cbDeriv.Checked;
            myControl.fIntError = new double [2] {0,0};
            myControl.fPosLast = new double [2] {0,0};
            myControl.iSP = new int [2] {Convert.ToInt32(tbSPx.Text),Convert.ToInt32(tbSPy.Text)};
        }
        private void InitializeMySysVars()
        {
            mySysVars.fKp = Convert.ToDouble(tbKp.Text);
            mySysVars.fKi = Convert.ToDouble(tbKi.Text);
            mySysVars.fKd = Convert.ToDouble(tbKd.Text);
            mySysVars.fFrict = Convert.ToDouble(tbFrict.Text);
            mySysVars.fGravity = 9.8;
        }
        // End Initializing Structures

        // Start Set Point Update Events
        private void UpdateSP(TextBox sender, EventArgs e)
        {
            int i;

            i = 0;
            if (sender.Name[4] == 'x') i = 0; else if (sender.Name[4] == 'y') i = 1;
            
            if (i == 0)
            {
                myControl.iSP[i] = Convert.ToInt32(sender.Text);
            }else
            {
                myControl.iSP[i] = -Convert.ToInt32(sender.Text);
            }

        }
        private void tbSP_Leave(object sender, EventArgs e)
        {
            UpdateSP((TextBox)sender, e);
        }
        private void tbSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) UpdateSP((TextBox)sender,e);
        }
        // End Set Point Update Events

        // Start Update Output Force
        private void btnUpDn_Click(object sender, EventArgs e)
        {
            Button btn;

            btn = (Button)sender;
            if (btn.Name[5] == 'X')
            {
                if (btn.Name[3] == 'U') AddForceOP(1, 0); else if (btn.Name[3] == 'D') AddForceOP(-1, 0);
            } else if (btn.Name[5] == 'Y')
            {
                if (btn.Name[3] == 'U') AddForceOP(0, 1); else if (btn.Name[3] == 'D') AddForceOP(0, -1);
            }
        }
        private void AddForceOP(int x, int y)
        {
            myForce.fOP[0] += (double)x;
            myForce.fOP[1] += (double)y;
        }
        // End Update Output Force

        // Start Error CheckBoxes
        private void cbProp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb;

            cb = (CheckBox)sender;
            myControl.bSwtProp = cb.Checked;
        }
        private void cbInt_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb;

            cb = (CheckBox)sender;
            myControl.bSwtInt = cb.Checked;
        }
        private void cbDeriv_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb;

            cb = (CheckBox)sender;
            myControl.bSwtDeriv = cb.Checked;
        }
        // End Error CheckBoxes

        private void UpdateLabels()
        {
            lblPX.Text = string.Format("{0}", myBall.fPos[0]);
            lblPY.Text = string.Format("{0}", myBall.fPos[1]);
            lblVX.Text = string.Format("{0}", myBall.fVel[0]);
            lblVY.Text = string.Format("{0}", myBall.fVel[1]);
            lblAX.Text = string.Format("{0}", myBall.fAcc[0]);
            lblAY.Text = string.Format("{0}", myBall.fAcc[1]);
            lblFX.Text = string.Format("{0}", myForce.fTotal[0]);
            lblFY.Text = string.Format("{0}", myForce.fTotal[1]);
            tbFX.Text = string.Format("{0}", myForce.fOP[0]);
            tbFY.Text = string.Format("{0}", myForce.fOP[1]);
        }


        private void tbFrict_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < myForce.fFrict.Length; i++ )
            {
                myForce.fFrict[i] = 0;
            }
            mySysVars.fFrict = Convert.ToDouble(tbFrict.Text);
        }

        // Start Change Error Constants
        private void tbKp_Leave(object sender, EventArgs e)
        {
            mySysVars.fKp = Convert.ToDouble(((TextBox)sender).Text);
        }
        private void tbKi_Leave(object sender, EventArgs e)
        {
            mySysVars.fKi = Convert.ToDouble(((TextBox)sender).Text);
        }
        private void tbKd_TextChanged(object sender, EventArgs e)
        {
            mySysVars.fKd = Convert.ToDouble(((TextBox)sender).Text);
        }
        // End Change Error Constants

        // Start Change Ball Properties
        private void tbSize_Leave(object sender, EventArgs e)
        {
            myBall.fDiam = Convert.ToDouble(((TextBox)sender).Text);
            InitializeStripes();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            myBall.fMass = Convert.ToDouble(((TextBox)sender).Text);
        }
        // End Change Ball Properties

        private void AddColorsToCombo(ComboBox cb)
        {
            cb.Items.Add("Blue");
            cb.Items.Add("Red");
            cb.Items.Add("Yellow");
            cb.Items.Add("White");
            cb.Items.Add("Black");
        }

        private void cbColorFill_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush b;
            string sColor = ((ComboBox)sender).Items[e.Index].ToString();

            b = new SolidBrush(Color.FromName(sColor));

            e.Graphics.FillRegion(b, new Region());
            
            e.Graphics.DrawString(sColor, ((ComboBox)sender).Font, b, e.Bounds.X, e.Bounds.Y);
        }
        private void cbColorFill_SelectedValueChanged(object sender, EventArgs e)
        {
            string sColor;

            sColor = (String)((ComboBox)sender).SelectedItem;
            ((ComboBox)sender).BackColor = Color.FromName(sColor);
            myBall.cFill = Color.FromName(sColor);
            myBall.cOutline = Color.FromName(sColor);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateNoiseForce()
        {
            int i;


            for (int i2 = 0; i2 < myForce.fNoise.Length; i2++)
            {
                Random r = new Random();
                i = r.Next(-1000, 1000);
                myForce.fNoise[i2] = i;
            }
                
            
        }
        private void btnNoise_Click(object sender, EventArgs e)
        {
            UpdateNoiseForce();
            lblNoiseX.Text = Convert.ToString(myForce.fNoise[0]);
            lblNoiseY.Text = Convert.ToString(myForce.fNoise[1]);
        }
    }
}
