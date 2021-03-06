﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelmholtzEquation.Process;

namespace HelmholtzEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process was started");
            ProcessHandler processHandler = new ProcessHandler();

            processHandler.StartProcess();

            State state = processHandler.States[1];

            Console.WriteLine("Process restarted from second step");
            processHandler.GoToState(state);

            processHandler.StartProcess();

            Console.ReadKey();
        }

        /*
        // для зміни умові задачі потрібно змінити imK,realK,EdgeRadius,ImBoundaryCondition,RealBoundaryCondition
        // Для отримання розвязку на іншій кривій потрібно змінити CurveRadiusToFindSolution
        static double realK =0.1;
        //static double outsidePointR = 1, outsidePointT = 3*Math.PI/2.0; 
        static double outsidePointR = 0.5, outsidePointT = 0;
        static Problem prblm;
        static void Main(string[] args)
        {
            Console.WriteLine("Dirichlet problem for Helmholtz equation \n Enter N (N*2 = number of points):");
            int N = int.Parse(Console.ReadLine());
            prblm = new Problem(EdgeRadius, realK, RealBoundaryCondition, ImBoundaryCondition); // 


            double[] sltn = prblm.Solve(N,CurveRadiusToFindSolution);



            int n = 2 * N;
            Console.WriteLine("\n  REAL part of solution on some curve: \n Accurate       \t Received ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} \t {1}", RealAccurateSolution(i * Math.PI / N), sltn[i]);
            }        
            Console.WriteLine("\n  IMAGINE part of solution on some curve: \n Accurate        \t  Received ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} \t {1} ", ImAccurateSolution(i * Math.PI / N), sltn[i + n]);
            }
            Console.WriteLine();
            double maxDeviation = Math.Abs(sltn[0] - RealAccurateSolution(0));
            for (int i = 1; i < n; i++)
            {
                maxDeviation = Math.Max(maxDeviation, Math.Abs(sltn[i] - RealAccurateSolution(i * Math.PI / N)));             
            }
            Console.WriteLine("\n Max deviation of real part of solution = {0}", maxDeviation);
            maxDeviation = Math.Abs(sltn[n] - ImAccurateSolution(0));
            for (int i = n; i < 2*n; i++)
            {
                maxDeviation = Math.Max(maxDeviation, Math.Abs(sltn[i] - ImAccurateSolution((i-n) * Math.PI / N)));
            }
            Console.WriteLine("\n Max deviation of imagine part of solution = {0}", maxDeviation);
            Console.ReadKey();
        }
        // 
        // 
        // функції які потрібно передати в Problem
        // 
        static double EdgeRadius(double t)
        {
            return 1; // може бути фукція що задає радіус
            //return Math.Sqrt(1 - 2*Math.Pow(Math.Sin(t),3) + Math.Pow(Math.Sin(t),4));
        }
        static double ImBoundaryCondition(double t)
        {
            //return 0;
            return prblm.H2(t,outsidePointR,outsidePointT);  // точка y (r = 0.5 , t (кут) = 0) належить обмеженій області D в якій ми НЕ шукаємо розвязок
        }
        static double RealBoundaryCondition(double t)
        {
            //return 5;
            return prblm.H1(t, outsidePointR, outsidePointT);  // точка y (r = 0.5 , t (кут) = 0) належить обмеженій області D в якій ми НЕ шукаємо розвязок
        }
        static double CurveRadiusToFindSolution(double t)
        {
            return 4;
        }
        static double ImAccurateSolution(double t)
        {
            return prblm.H2(t, outsidePointR, outsidePointT);
        }
        static double RealAccurateSolution(double t)
        {
            return prblm.H1(t, outsidePointR, outsidePointT);
        }*/
    }
}
