C#调用C++方式。
C++不需托管,dllexport导出
extern "C" _declspec(dllexport)int add(int a, int b, char * str)
C#dllimport导入
[DllImport("Alg.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] 
    public static extern int add(int a, int b,String s);

适合导出个别函数，如果需要导出的函数特别多，对每个函数都需要写dllimport，不方便

通过托管C++做中介，比较方便