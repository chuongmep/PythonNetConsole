// See https://aka.ms/new-console-template for more information
//https://somegenericdev.medium.com/calling-python-from-c-an-introduction-to-pythonnet-c3d45f7d5232
using PythonNetConsole;

PythonInterop.RunPythonCode(
    @"import clr
clr.AddReference(""System"");
from System.Diagnostics import Debug;
Debug.WriteLine(""this line was printed by Python in the Debug window!"");"
    );
PythonInterop.RunPythonCode(@"print(""hello world from python!"")");
PythonInterop.RunPythonCode(
    @"import clr
clr.AddReference(""System"");
from System import DateTime
mydate=DateTime(2010, 5, 11)
print(mydate)
");
PythonInterop.RunPythonCode(@"import numpy as np
a = np.array([0,2,3,])
print(a)
"

);
//Try see it import or not
PythonInterop.RunPythonCode(@"import pandas as pd
a = np.array([0,2,3,])
print(a)
"

);
//Try pandas
PythonInterop.RunPythonCode(@"import pandas as pd
df = pd.DataFrame(np.array([[1, 2, 3], [4, 5, 6], [7, 8, 9]]),columns=['a', 'b', 'c'])
print(df)
"
);
//try tensorflow 2.8
PythonInterop.RunPythonCode(@"import tensorflow as tf
print(tf.__version__)");

Console.WriteLine("End Console");
Console.ReadKey();