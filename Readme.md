C#����C++��ʽ��
C++�����й�,dllexport����
extern "C" _declspec(dllexport)int add(int a, int b, char * str)
C#dllimport����
[DllImport("Alg.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] 
    public static extern int add(int a, int b,String s);

�ʺϵ����������������Ҫ�����ĺ����ر�࣬��ÿ����������Ҫдdllimport��������

ͨ���й�C++���н飬�ȽϷ���