using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalPendulum
{
    struct PointD
    {
        public double angle;
        public double speed;
        public double time;

        public PointD(double angle_, double speed_, double time_)
        {
            this.angle = angle_;
            this.speed = speed_;
            this.time = time_;
        }
    }

    struct RKresult
    {
	    public double t;
        public double x;
        public double Vx;
        public double xOld;

	    public RKresult(double t_, double x_ , double Vx_)
	    {
		    this.t = t_;
            this.x = x_;
            this.Vx = Vx_;

            this.xOld = x_;
	    }
    }

    class PendulumCalculate
    {
        private const double g = 9.81523;                

        private double Length;                          
        private double Weight;                          

        private double dt;                              
        public double time;                             

        private double ViscousFrictionCoefficient;      
        private double DryFrictionCoefficient;          

        public double CurrentAngle;                     
        public double CurrentAngleSpeed;                

        public double ViscousFrictionForce;             
        public double DryFrictionForce;                 
        public double MyForce;                          

        public double StartAngle;                       
        public double EndAngle;                         

        private int BWidth, BHeight;                    

        public int Number;                              

        public List<PointD> data = new List<PointD>();

        public PendulumCalculate(double PendulumLength, double PendulumAngle, double PendulumWeight, int BitmatWidth, int BitmatHeight, double PendulumViscousFrictionCoefficient, double PendulumDryFrictionCoefficient, double PendulumStartAngleSpeed, double PendulumMyForce, double PendulumStartAngle, double PendulumEndAngle, int PhaseNumber, double PendulumDt)
        {
            Length = PendulumLength;
            CurrentAngle = Conversion(PendulumAngle);
            Weight = PendulumWeight;
            CurrentAngleSpeed = PendulumStartAngleSpeed;
            dt = PendulumDt;

            BWidth = BitmatWidth;
            BHeight = BitmatHeight;

            ViscousFrictionCoefficient = PendulumViscousFrictionCoefficient;
            DryFrictionCoefficient = PendulumDryFrictionCoefficient;

            MyForce = PendulumMyForce;
            StartAngle = Conversion(PendulumStartAngle);
            EndAngle = Conversion(PendulumEndAngle);

            Number = PhaseNumber;
        }

        double Conversion(double angle)
        {
            double rad = angle * (Math.PI / 180);
            return rad;
        }

        public void FillList()
        {
            double CurAng, CurAngSpeed, time_;
            CurAng = CurrentAngle;
            CurAngSpeed = CurrentAngleSpeed;
            time_  = time;

            for (int i = 0; i < Number; i++)
            {
                data.Add(new PointD(CurAng, CurAngSpeed, time_));
                CurAng -= 0.2;
                CurAngSpeed -= 0.2;
            }
        }

        public double[] PhaseCalculate(double angle, double speed, double time)
        {
            double[] mas = new double[3];
            RKresult Koor = RKMethod(time, angle, speed);
            angle = Koor.x;
            speed = Koor.Vx;
            time = Koor.t;

            mas[0] = angle;
            mas[1] = speed;
            mas[2] = time;
            return mas;
        }


        private double CalculateViscousFrictionForce(double V)
        {
            ViscousFrictionForce = -ViscousFrictionCoefficient * V;
            return ViscousFrictionForce;
        }

        private double CalculateDryFrictionForce(double V)
        {
            if (V > 0)
            {
                DryFrictionForce = -DryFrictionCoefficient * Weight * g;
            }
            else if (V < 0)
            {
                DryFrictionForce = DryFrictionCoefficient * Weight * g;
            }
            return DryFrictionForce;
        }

        public int[] CalculateFollowingProvision()
        {
            RKresult Koor = RKMethod(time, CurrentAngle, CurrentAngleSpeed);

            CurrentAngle = Koor.x;
            CurrentAngleSpeed = Koor.Vx;
            time = Koor.t;

            int anchorX = (BWidth / 2) - 12,
                anchorY = BHeight / 18,
                ballX = anchorX + (int)(Math.Sin(CurrentAngle) * 200),
                ballY = anchorY + (int)(Math.Cos(CurrentAngle) * 200);

            int[] ResultPoints = {anchorX, anchorY, ballX, ballY};
            return ResultPoints;
        }

        private double formulaAngle(double V)
        {
            return V;
        }

        private double formulaSpeed(double a, double V)
        {
            if (EndAngle <= a && a <= StartAngle)
            {
                return -(g / Length) * a + CalculateViscousFrictionForce(V) + CalculateDryFrictionForce(V) + (MyForce * Length * Math.Sin(a));
            }
            else
            {
                return -(g / Length) * a + CalculateViscousFrictionForce(V) + CalculateDryFrictionForce(V);
            }
            
        }

        private RKresult RKMethod(double t, double a, double v)
        {
	        double k1a, k1v, k2a, k2v, k3a, k3v, k4a, k4v;

            k1v = formulaSpeed(a, v) * dt;
            k1a = formulaAngle(v) * dt;
            k2v = formulaSpeed(a + k1a / 2, v + k1v / 2) * dt;
            k2a = formulaAngle(v + k1v / 2) * dt;
            k3v = formulaSpeed(a + k2a / 2, v + k2v / 2) * dt;
            k3a = formulaAngle(v + k2v / 2) * dt;
            k4v = formulaSpeed(a + k3a, v + k3v) * dt;
            k4a = (v + k3v) * dt;



	        double tNew = t + dt;
	        double aNew = a + (k1a + 2 * k2a + 2 * k3a + k4a) / 6;
	        double vNew = v + (k1v + 2 * k2v + 2 * k3v + k4v) / 6;
            

	        RKresult koor4 = new RKresult(tNew, aNew, vNew);
	        return koor4;
        }
    }
}
