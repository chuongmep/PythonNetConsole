﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace PythonNetConsole
{
    public class PythonInterop
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\Chuong.Ho\AppData\Local\Programs\Python\Python39\python39.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        public static void RunPythonCode(string pycode)
        {
            Initialize();
            using (Py.GIL())
            {
                PythonEngine.RunSimpleString(pycode);
            }
        }
        //public static void RunPythonCode(string pycode, object parameter, string parameterName)
        //{
        //    Initialize();
        //    using (Py.GIL())
        //    {
        //        using (PyScope scope = Py.CreateScope())
        //        {
        //            scope.Set(parameterName, parameter.ToPython());
        //            scope.Exec(pycode);
        //        }

        //    }
        //}
        //public static object RunPythonCodeAndReturn(string pycode, object parameter, string parameterName, string returnedVariableName)
        //{
        //    object returnedVariable = new object();
        //    Initialize();
        //    using (Py.GIL())
        //    {
        //        using (PyScope scope = Py.CreateScope())
        //        {
        //            scope.Set(parameterName, parameter.ToPython());
        //            scope.Exec(pycode);
        //            returnedVariable = scope.Get<object>(returnedVariableName);
        //        }
        //    }
        //    return returnedVariable;
        //}
    }
}
